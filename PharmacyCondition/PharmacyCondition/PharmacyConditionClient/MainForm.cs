using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PharmacyCondition.RemoteDatabase;
using PharmacyConditionClient.Properties;

namespace PharmacyConditionClient
{
	public partial class MainForm : Form
	{
		private const string Version = "0.5.3.1";
		private const int DirtyBarcodeRow = 2;

		private string _temporaryBarcode = "";
		private BackgroundClientWithWcf _backgroundWcf;

		private static class Win32
		{
			[DllImport("kernel32.dll")]
			public static extern Boolean AllocConsole();
			[DllImport("kernel32.dll")]
			public static extern Boolean FreeConsole();
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainFormShown(object sender, EventArgs e)
		{
			UpdateToolStripLabelPrefix();

			Text += @" - ver.: " + Version;

			Settings.Default.ComputerGuid = Guid.NewGuid();
			Settings.Default.Save();
		}

		private void MainFormActivated(object sender, EventArgs e)
		{
			if (toolStripTextBoxBarcode.Enabled)
				toolStripTextBoxBarcode.Focus();
		}

		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (_backgroundWcf != null)
				_backgroundWcf.CancelAsync();
		}

		private void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			//keys: F9, F10, F11, F12
			switch (e.KeyCode)
			{
				case Keys.F9:
					break;

				case Keys.F10:
					break;

				case Keys.F11:
					break;

				case Keys.F12:
					break;
			}
		}

		private void ToolStripButtonStartClick(object sender, EventArgs e)
		{
			toolStripButtonStop.Enabled = true;
			toolStripButtonStart.Enabled = false;
			toolStripTextBoxBarcode.Enabled = true;
			toolStripTextBoxBarcode.Focus();

			_backgroundWcf = new BackgroundClientWithWcf 
								 { 
									DataGridViewBarcode = dataGridView, 
									ToolStripTextBoxLastBarcode = toolStripLabelLastReadedCode,
									ToolStripStartButton = toolStripButtonStart,
									ToolStripStopButton = toolStripButtonStop,
									ToolStripTextBoxBarcode = toolStripTextBoxBarcode
								 };
			_backgroundWcf.RunWorkerAsync();
		}

		private void ToolStripButtonStopClick(object sender, EventArgs e)
		{
			toolStripButtonStop.Enabled = false;
			toolStripButtonStart.Enabled = true;
			toolStripTextBoxBarcode.Enabled = false;

			_backgroundWcf.CancelAsync();
		}

		private void ToolStripButtonIncreaseQuantityClick(object sender, EventArgs e)
		{
			SetBackgroundCommand(BackgroundClientWithWcf.FormEventCommands.DataGridViewQuantityInRowIncrease);
		}

		private void ToolStripButtonDecreaseQuantityClick(object sender, EventArgs e)
		{
			SetBackgroundCommand(BackgroundClientWithWcf.FormEventCommands.DataGridViewQuantityInRowDecrease);
		}

		private void ToolStripButtonPartialQuantityClick(object sender, EventArgs e)
		{
			var addPartialForm = new AddPartialQuantity();

			if (addPartialForm.ShowDialog() != DialogResult.OK) return;
			_backgroundWcf.PartialQuantity = addPartialForm.ReturnCalculations;
			SetBackgroundCommand(BackgroundClientWithWcf.FormEventCommands.DataGridViewQuantityAddPartial);
		}

		private void ToolStripButtonAddBarcodeClick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToolStripButtonPreferencesClick(object sender, EventArgs e)
		{
			var settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
			UpdateToolStripLabelPrefix();
		}

		private void ToolStripButtonAboutClick(object sender, EventArgs e)
		{
			var aboutForm = new AboutForm();
			aboutForm.ShowDialog();
		}

		private void ToolStripTextBoxBarcodeKeyPress(object sender, KeyPressEventArgs e)
		{
			//zdarzenie występuje kiedy wprowadzony kod kreskowy zawiera prefix
			if (Settings.Default.PrefixEnabled)
			{
				if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == Settings.Default.Prefix)
				{
					_temporaryBarcode += e.KeyChar;
				}
			}
			//zdarzenie występuje kiedy wprowadzony kod kreskowy nie zawiera prefixu
			else
			{
				if (e.KeyChar >= 48 && e.KeyChar <= 57)
				{
					_temporaryBarcode += e.KeyChar;
				}
			}
			
			//zdarzenie występuje kiedy użytkownik (lub czytnik) wprowadzi znak enter
			if (e.KeyChar == (char) Keys.Enter)
			{
				//wprowadzony kod kreskowy (tzw. kod brudny) musi mieć 14 znaków (razem z prefixem),
				//natomiast kod kreskowy (tzw. czysty) musi mieć 13 znaków
				if (_temporaryBarcode.Length >= 13 && _temporaryBarcode.Length <= 14)
				{
					//dodaje wywołanie zdarzenia wyszukania kodu do bazy danych
					//jak również dodania do tabeli od strony klienta i serwera
					_backgroundWcf.FormMessageStacks.Enqueue(new BackgroundClientWithWcf.FormEventStack
					{
						EventCommand = BackgroundClientWithWcf.FormEventCommands.DataGridViewProductUpdate,
						Data = _temporaryBarcode
					});

					toolStripTextBoxBarcode.Text = "";
					_temporaryBarcode = "";
				}
			}
		}

		private void ToolStripTextBoxBarcodeTextChanged(object sender, EventArgs e)
		{
			//kiedy następuje wpisywanie z klawiatury kodu kreskowego 
			//uaktualnia wewnętrzny tymczasowy tekst
			var text = ((ToolStripTextBox)sender).Text;

			if (text.Length >= 13 && text.Length <= 14)
			{
				_temporaryBarcode = text;
			}
		}

		private void DataGridViewSelectionChanged(object sender, EventArgs e)
		{
			toolStripButtonDecreaseQuantity.Enabled = false;
			toolStripButtonIncreaseQuantity.Enabled = false;
			toolStripButtonPartialQuantity.Enabled = false;
			toolStripButtonAddBarcode.Enabled = false;

			var dataGridViewLocal = (DataGridView) sender;

			try
			{
				var selected = (BarcodeTypes) dataGridViewLocal.SelectedRows[0].Cells[1].Value;

				switch (selected)
				{
					case BarcodeTypes.Delivery:
					case BarcodeTypes.Ean:
						toolStripButtonDecreaseQuantity.Enabled = true;
						toolStripButtonIncreaseQuantity.Enabled = true;
						toolStripButtonPartialQuantity.Enabled = true;
						break;

					case BarcodeTypes.NotExisting:
					case BarcodeTypes.Selled:
						toolStripButtonDecreaseQuantity.Enabled = true;
						toolStripButtonIncreaseQuantity.Enabled = true;
						toolStripButtonPartialQuantity.Enabled = true;
						toolStripButtonAddBarcode.Enabled = true;
						break;
				}
			}
			catch(Exception)
			{
				//TODO: występuje przy synchronizacji
				return;
			}
		}

		private void UpdateToolStripLabelPrefix()
		{
			toolStripLabelPrefix.Text = Settings.Default.PrefixEnabled
											? string.Format(@"Włączono prefix({0})!", Settings.Default.Prefix)
											: @"Prefix wyłączony!";
		}

		private void SetBackgroundCommand(BackgroundClientWithWcf.FormEventCommands command)
		{
			var dirtyBarcode = (string)dataGridView.SelectedRows[0].Cells[DirtyBarcodeRow].Value;

			_backgroundWcf.FormMessageStacks.Enqueue(new BackgroundClientWithWcf.FormEventStack
			{
				Data = dirtyBarcode,
				EventCommand = command
			});
		}
	}
}
