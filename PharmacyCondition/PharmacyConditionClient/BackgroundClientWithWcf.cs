using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using PharmacyCondition.RemoteDatabase;
using PharmacyCondition.Services;
using PharmacyConditionClient.Properties;

namespace PharmacyConditionClient
{
	public class BackgroundClientWithWcf : BackgroundWorker
	{
		#region Public and private properties
		public DataGridView DataGridViewBarcode { private get; set; }
		public ToolStripLabel ToolStripTextBoxLastBarcode { private get; set; }
		public ToolStripButton ToolStripStopButton { private get; set; }
		public ToolStripButton ToolStripStartButton { private get; set; }
		public ToolStripTextBox ToolStripTextBoxBarcode { private get; set; }
		public Queue<FormEventStack> FormMessageStacks { get; private set; }
		public double PartialQuantity { set; private get; }

		private readonly Client _client;
		private Queue<BackgroundEventStack> BackgroundMessageStacks { set; get; }
		private bool _clientNameWasNotSent = true;
		#endregion

		public BackgroundClientWithWcf()
		{
			WorkerReportsProgress = true;
			WorkerSupportsCancellation = true;

			//wstępna inicjalizacja potrzebnych danych
			_client = new Client();
			FormMessageStacks = new Queue<FormEventStack>();
			BackgroundMessageStacks = new Queue<BackgroundEventStack>();
		}
		
		//rozkłada zadania do aktualizacji widoku i wysyła potrzebne informacje do serwera
		protected override void OnDoWork(DoWorkEventArgs e)
		{
			_client.Open();

			while (true)
			{
				//w razie wywołania zdarzenia zatrzymania klienta
				if (CancellationPending)
				{
					e.Cancel = true;
					_client.Channel.ClientDisconnectedToServer(GetSettings().ComputerName, GetSettings().ComputerGuid.ToString());
					_client.Close();
					return;
				}

				//sprawdzanie podłączenia do serwera, metoda IsServerRunnig() domyślnie zwraca true
				bool serverRunning;
				try
				{
				    serverRunning = _client.Channel.IsServerRunning();

					//wysyłanie informacji o akuratnie podłączonym kliencie do serwera
					//jest on wysyłany tylko raz
					if (_clientNameWasNotSent)
					{
						_client.Channel.ClientConnectedToServer(GetSettings().ComputerName, GetSettings().ComputerGuid.ToString());
						_clientNameWasNotSent = false;
					}
				}
				catch(Exception ex)
				{
					ShowConnectionErrorMessage(ex);
					ReportProgress(0);
					return;
				}

				//jeżeli serwer jest uruchomiony i działa - kontynuuje pracę
				if (!serverRunning) continue;

				try
				{
					if (_client.Channel.GetSynchronizeWithServer())
					{
						FormMessageStacks.Enqueue(new FormEventStack
						                          	{
						                          		Data = Settings.Default.ComputerName,
						                          		EventCommand = FormEventCommands.DataGridViewSynchronizeWithServer
						                          	});
					}
				}
				catch (Exception ex)
				{
					ShowConnectionErrorMessage(ex);
					ReportProgress(0);
					return;
				}
				if (FormMessageStacks.Count == 0)
				{
					Thread.Sleep(10);
				}
				else
				{
					//pobiera pierwszy element z listy zdarzeń
					var formMessageStackItem = FormMessageStacks.Dequeue();

					switch (formMessageStackItem.EventCommand)
					{
						case FormEventCommands.DataGridViewSynchronizeWithServer:
							_client.Channel.SendClientName(formMessageStackItem.Data);
							Thread.Sleep(500);
							var clientList = _client.Channel.GetClientList();
							ReportProgress(0, clientList);
							EnqueueBackgroundEventStack(null, BackgroundEventCommands.DataGridViewProductUpdateFromServer, null);
							Thread.Sleep(500);
							_client.Channel.SetSynchronizeWithServer(false);
							break;

						case FormEventCommands.DataGridViewProductUpdate:
							//aktualizacja danych na serwerze
							var product = _client.Channel.FindProductOnServer(formMessageStackItem.Data, GetPrefix(), 
																	  GetSettings().ComputerName, GetSettings().ComputerGuid.ToString());

							//aktualizacja danych na kliencie
							EnqueueBackgroundEventStack(product, BackgroundEventCommands.DataGridViewProductUpdate, null);
							EnqueueBackgroundEventStack(product, BackgroundEventCommands.LabelLastBarcodeUpdate, null);
							break;

						case FormEventCommands.DataGridViewQuantityInRowIncrease:
							//aktualizacja danych na serwerze
							_client.Channel.IncreaseQuantityRowOnServer(formMessageStackItem.Data, GetPrefix(), 
													 GetSettings().ComputerName, GetSettings().ComputerGuid.ToString());

							//aktualizacja danych na kliencie
							EnqueueBackgroundEventStack(null, BackgroundEventCommands.RowIncreaseQuantity, null);
							break;

						case FormEventCommands.DataGridViewQuantityInRowDecrease:
							//aktualizacja danych na serwerze
							_client.Channel.DecreaseQuantityRowOnServer(formMessageStackItem.Data, GetPrefix(),
													 GetSettings().ComputerName, GetSettings().ComputerGuid.ToString());

							//aktualizacja danych na kliencie
							EnqueueBackgroundEventStack(null, BackgroundEventCommands.RowDecreaseQuantity, null);
							break;

						case FormEventCommands.DataGridViewQuantityAddPartial:
							//aktualizacja danych na serwerze
							_client.Channel.AddPartialQuantityRowOnServer(formMessageStackItem.Data, PartialQuantity, GetPrefix(),
													   GetSettings().ComputerName, GetSettings().ComputerGuid.ToString());

							//aktualizacja danych na kliencie
							EnqueueBackgroundEventStack(null, BackgroundEventCommands.RowPartialQuantity, null);
							break;
					}
				}
			}
		}

		//aktualizuje dane na widoku
		protected override void OnProgressChanged(ProgressChangedEventArgs e)
		{
			if (BackgroundMessageStacks.Count <= 0) return;
			var stackItem = BackgroundMessageStacks.Dequeue();

			switch (stackItem.EventCommand)
			{
				case BackgroundEventCommands.DataGridViewProductUpdateFromServer:
					try
					{
						var clientList = (IEnumerable<ClientData>) e.UserState;
						foreach (var clientData in clientList)
						{
							DataGridViewBarcode.Rows.Add(clientData.ID, clientData.BarcodeType, clientData.DirtyBarcode,
							                             clientData.CleanBarcode, clientData.ProductName, clientData.QuantityCount,
							                             clientData.DateAdded, clientData.DateModified);
						}
					}
					catch(Exception)
					{
						//TODO: wywala się...
						return;
					}
					break;

				case BackgroundEventCommands.DataGridViewProductUpdate:
					DataGridViewBarcode.UpdateRow(stackItem.Product);
					break;

				case BackgroundEventCommands.LabelLastBarcodeUpdate:
					string tempName;
					if (string.IsNullOrWhiteSpace(stackItem.Product.Name))
					{
						tempName = "Produkt nie znaleziony/istniejący";
					}
					else
					{
						tempName = stackItem.Product.Name.Length < 30
						           ? stackItem.Product.Name
						           : stackItem.Product.Name.Substring(0, 30);
					}

					ToolStripTextBoxLastBarcode.Text = string.Format(@"{0} - {1}...", stackItem.Product.CleanBarcode, tempName);
					break;

				case BackgroundEventCommands.RowIncreaseQuantity:
					DataGridViewBarcode.IncreaseQuantityRow();
					break;

				case BackgroundEventCommands.RowDecreaseQuantity:
					DataGridViewBarcode.DecreaseQuantityRow();
					break;

				case BackgroundEventCommands.RowPartialQuantity:
					DataGridViewBarcode.AddPartialQuantityRow(PartialQuantity);
					break;

				case BackgroundEventCommands.ErrorMessage:
					MessageForm.ShowErrorMessage(stackItem.Event);
					CancelAsync();
					ToolStripStopButton.Enabled = false;
					ToolStripStartButton.Enabled = true;
					ToolStripTextBoxBarcode.Enabled = false;
					break;
			}
		}

		#region Private methods
		private static string GetPrefix()
		{
			if (!string.IsNullOrEmpty(Settings.Default.Prefix.ToString()) && Settings.Default.PrefixEnabled)
			{
				return Settings.Default.Prefix.ToString();
			}
			return null;
		}

		private static Settings GetSettings()
		{
			return Settings.Default;
		}

		private void ShowConnectionErrorMessage(Exception ex)
		{
			var basicErrorMessageText = "Wystąpił błąd połączenia.\r\n" +
			                            "Serwer nie odpowiada.\r\n\r\n" +
										"Szczegóły błędu:\r\n" +
										ex.Message;

			if (ex.InnerException == null)
			{
				BackgroundMessageStacks.Enqueue(new BackgroundEventStack
				{
					EventCommand = BackgroundEventCommands.ErrorMessage,
					Event = basicErrorMessageText
				});
			}
			else
			{
				BackgroundMessageStacks.Enqueue(new BackgroundEventStack
				{
					EventCommand = BackgroundEventCommands.ErrorMessage,
					Event = basicErrorMessageText + "\r\n" + ex.InnerException.Message
				});
			}
		}

		private void EnqueueBackgroundEventStack(Product product, BackgroundEventCommands eventCommand, string eventText)
		{
			BackgroundMessageStacks.Enqueue(new BackgroundEventStack
											{
												Product = product,
												EventCommand = eventCommand,
												Event = eventText
											});
			ReportProgress(0);
		}
		#endregion

		#region Stacks and their enums
		private class BackgroundEventStack
		{
			public Product Product { set; get; }
			public string Event { set; get; }
			public BackgroundEventCommands EventCommand { set; get; }
		}

		private enum BackgroundEventCommands
		{
			ErrorMessage,
			DataGridViewProductUpdate,
			LabelLastBarcodeUpdate,
			RowIncreaseQuantity,
			RowDecreaseQuantity,
			RowPartialQuantity,
			DataGridViewProductUpdateFromServer,
		}

		public enum FormEventCommands
		{
			DataGridViewProductUpdate,
			DataGridViewQuantityInRowIncrease,
			DataGridViewQuantityInRowDecrease,
			DataGridViewQuantityAddPartial,
			DataGridViewSynchronizeWithServer
		}

		public class FormEventStack
		{
			public string Data { set; get; } //wykorzystany ogółem w celu unifikacji
			public FormEventCommands EventCommand { set; get; }
		}
		#endregion
	}
}