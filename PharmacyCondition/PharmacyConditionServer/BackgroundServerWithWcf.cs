using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using PharmacyCondition.LocalDatabase;
using PharmacyCondition.RemoteDatabase;
using PharmacyCondition.Services;

namespace PharmacyConditionServer
{
	public class BackgroundServerWithWcf : BackgroundWorker
	{
		public DataGridView DataGridViewGood { private get; set; }
		public DataGridView DataGridViewBad { private get; set; }
		public ListBox ListBoxForConnectedClients { private get; set; }
		public ListBox ListBoxServerLog { private get; set; }

		public LocalRepository LocalRepository { private get; set; }
		public bool SynchronizeWithClients { private get; set; }
		public string SessionId { get; set; }

		private readonly Host _host;

		public BackgroundServerWithWcf()
		{
			WorkerReportsProgress = true;
			WorkerSupportsCancellation = true;

			_host = new Host();
		}

		protected override void OnDoWork(DoWorkEventArgs e)
		{
			_host.Open();

			while (true)
			{
				if (CancellationPending)
				{
					e.Cancel = true;
					_host.Close();
					return;
				}

				if (SynchronizeWithClients)
				{
					_host.ProductService.SetSynchronizeWithServer(true);
					Thread.Sleep(500);
					var clientName = ProductService.GetClientName();

					var badList = from bad in LocalRepository.GetAllBadProducts(SessionId)
					              where bad.ProductClientAdded.Contains(clientName)
					              select bad;

					var goodList = from good in LocalRepository.GetAllGoodProducts(SessionId)
								   where good.ProductAddedClient.Contains(clientName)
								   select good;

					var clientList = new List<ClientData>();
					foreach (var badProduct in badList)
					{
						var productName = "";
						switch (badProduct.ProductBarcodeType)
						{
							case "Sprzedany":
								productName = "Błąd - Sprzedany";
								break;

							case "Nie istniejący":
								productName = "Błąd - Nie istniejący";
								break;
						}

						clientList.Add(new ClientData
											{
												ID = badProduct.ProductId,
												BarcodeType = badProduct.ProductBarcodeType,
												DirtyBarcode = badProduct.ProductDirtyBarcode,
												CleanBarcode = badProduct.ProductCleanBarcode,
												ProductName = productName,
												DateAdded = badProduct.ProductDateAdded,
												DateModified = badProduct.ProductDateAdded,
												QuantityCount = badProduct.ProductQuantityCounted
											});
					}

					foreach (var goodProduct in goodList)
					{
						clientList.Add(new ClientData
						{
							ID = goodProduct.ProductID,
							BarcodeType = goodProduct.ProductBarcodeType,
							DirtyBarcode = goodProduct.ProductDirtyBarcode,
							CleanBarcode = goodProduct.ProductCleanBarcode,
							ProductName = goodProduct.ProductName,
							DateAdded = goodProduct.ProductDateAdded,
							DateModified = goodProduct.ProductDateModified,
							QuantityCount = goodProduct.ProductQuantityCounted
						});
					}

					_host.ProductService.SetClientList(clientList);
					Thread.Sleep(1000);
					SynchronizeWithClients = _host.ProductService.GetSynchronizeWithServer();
				}

				if (_host.ProductService.HowManyStackItemsInBackgroundServerEventStackQueue() == 0)
				{
					Thread.Sleep(10);
				}
				else
				{
					var stackItem = _host.ProductService.GetBackgroundServerEventStackFromQueue();
					ReportProgress(0, stackItem);
				}
			}
		}

		protected override void OnProgressChanged(ProgressChangedEventArgs e)
		{
			//Update all controls on form
			var stackItem = (BackgroundServerEventStack) e.UserState;

			switch (stackItem.EventCommand)
			{
				case BackgroundServerEventCommands.FindProduct:
					switch (stackItem.Product.BarcodeType)
					{
						case BarcodeTypes.Delivery:
						case BarcodeTypes.Ean:
							DataGridViewGood.UpdateGoodRow(stackItem.Product, _host, stackItem.ClientName, 
														   stackItem.ClientGuid, LocalRepository);
							break;

						case BarcodeTypes.NotExisting:
						case BarcodeTypes.Selled:
							DataGridViewBad.UpdateBadRow(stackItem.Product, stackItem.ClientName, 
														 stackItem.ClientGuid, LocalRepository);
							break;
					}
					ListBoxServerLog.UpdateLog(stackItem.ClientName, stackItem.ClientGuid,
											   "'Dodawanie/modyfikacja produktu'", stackItem.Product, null);
					break;

				case BackgroundServerEventCommands.IncreaseQuantity:
					ExtensionsS.IncreaseQuantityRow(DataGridViewGood, DataGridViewBad, stackItem.FirstEvent, LocalRepository);
					ListBoxServerLog.UpdateLog(stackItem.ClientName, stackItem.ClientGuid,
											   "'+1'", stackItem.Product, stackItem.FirstEvent);
					break;

				case BackgroundServerEventCommands.DecreaseQuantity:
					var haveArrivedToZero = ExtensionsS.DecreaseQuantityRow(DataGridViewGood, DataGridViewBad, stackItem.FirstEvent, LocalRepository);

					ListBoxServerLog.UpdateLog(stackItem.ClientName, stackItem.ClientGuid,
					                           haveArrivedToZero ? "'-1 (doszedł do 0)'" : "'-1'", 
											   stackItem.Product, stackItem.FirstEvent);
					break;

				case BackgroundServerEventCommands.ClientConnect:
					ListBoxForConnectedClients.ClientConnected(stackItem.ClientName, stackItem.ClientGuid);
					break;

				case BackgroundServerEventCommands.ClientDisconnect:
					ListBoxForConnectedClients.ClientDisconnected(stackItem.ClientName, stackItem.ClientGuid);
					break;

				case BackgroundServerEventCommands.AddPartialQuantity:
					ExtensionsS.AddPartialQuantityRow(DataGridViewGood, DataGridViewBad, 
													  stackItem.FirstEvent, Convert.ToDouble(stackItem.SecondEvent), 
													  LocalRepository);
					ListBoxServerLog.UpdateLog(stackItem.ClientName, stackItem.ClientGuid,
					                           string.Format("'Częściowy stan (+{0})'", stackItem.SecondEvent), 
											   stackItem.Product, stackItem.FirstEvent);
					break;
			}
		}
	}
}