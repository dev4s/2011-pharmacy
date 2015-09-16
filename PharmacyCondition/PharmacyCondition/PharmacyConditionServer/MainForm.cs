using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PharmacyCondition.LocalDatabase;

namespace PharmacyConditionServer
{
	public partial class MainForm : Form
	{
		private const string Version = "0.5.3.1";

		private BackgroundServerWithWcf _backgroundWcf;
		private LocalRepository _localRepository;

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

			//Win32.AllocConsole();
		}

		private void MainFormShown(object sender, EventArgs e)
		{
			Text += @" - ver.: " + Version;

			_localRepository = new LocalRepository();
			_localRepository.CreateSession(DateTime.Now);

			foreach (var session in _localRepository.GetAllSessions())
			{
				listBoxSessionHistory.Items.Add(string.Format("({0}) - {1}", session.ID, session.DateAdded));
			}

			if (listBoxSessionHistory.Items.Count > 0)
			{
				listBoxSessionHistory.SelectedIndex = 0;
			}
		}

		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (_backgroundWcf != null)
				_backgroundWcf.CancelAsync();
		}

		private void ToolStripButtonStartClick(object sender, EventArgs e)
		{
			toolStripButtonStop.Enabled = true;
			toolStripButtonStart.Enabled = false;

			_backgroundWcf = new BackgroundServerWithWcf
			                 	{
			                 		DataGridViewGood = dataGridViewGood,
									DataGridViewBad = dataGridViewBad,
									ListBoxForConnectedClients = listBoxConnectedClients,
									ListBoxServerLog = listBoxServerLog,
									LocalRepository = _localRepository,
			                 	};
			_backgroundWcf.RunWorkerAsync();	
		}

		private void ToolStripButtonStopClick(object sender, EventArgs e)
		{
			toolStripButtonStart.Enabled = true;
			toolStripButtonStop.Enabled = false;

			_backgroundWcf.CancelAsync();

			//TODO: show yes/no message when there are clients and server still have data to compute
		}

		private void ToolStripButtonExportClick(object sender, EventArgs e)
		{
			switch (saveFileExportDialog.ShowDialog())
			{
				case DialogResult.Cancel:
					break;

				case DialogResult.OK:
					var resultGood = "";
					foreach (DataGridViewColumn col in dataGridViewGood.Columns)
					{
						resultGood += col.HeaderText + ";";
					}
					resultGood += "\r\n";
					foreach (DataGridViewRow row in dataGridViewGood.Rows)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							resultGood += cell.Value + ";";
						}
						resultGood += "\r\n";
					}

					var resultBad = "";
					foreach (DataGridViewColumn col in dataGridViewBad.Columns)
					{
					    resultBad += col.HeaderText + ";";
					}
					resultBad += "\r\n";
					foreach (DataGridViewRow row in dataGridViewBad.Rows)
					{
					    foreach (DataGridViewCell cell in row.Cells)
					    {
					        resultBad += cell.Value + ";";
					    }
					    resultBad += "\r\n";
					}

					var pathGood = saveFileExportDialog.FileName.Replace(".csv", "") + "_poprawne.csv";
					var pathBad = saveFileExportDialog.FileName.Replace(".csv", "") + "_błędne.csv";

					if (File.Exists(pathGood))
					{
						File.Delete(pathGood);
					}
					else if(File.Exists(pathBad))
					{
						File.Delete(pathBad);
					}

					using (var stream = File.CreateText(pathGood))
					{
						stream.Write(resultGood);
					}
					
					using (var stream = File.CreateText(pathBad))
					{
						stream.Write(resultBad);
					}

					break;
			}
		}

		private void ToolStripButtonPreferencesClick(object sender, EventArgs e)
		{
			var settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}

		private void ToolStripButtonAboutClick(object sender, EventArgs e)
		{
			var aboutForm = new AboutForm();
			aboutForm.ShowDialog();
		}

		private void ButtonReadSelectedHistorySessionClick(object sender, EventArgs e)
		{
			var selectedHistory = listBoxSessionHistory.SelectedItem;

			var regex = new Regex(@"\((?<id>.+)\)");
			var sessionId = regex.Match(selectedHistory.ToString()).Groups["id"].Value;

			foreach (var good in _localRepository.GetAllGoodProducts(sessionId))
			{
				dataGridViewGood.Rows.Add(good.ProductID, good.ProductDirtyBarcode, good.ProductCleanBarcode, good.ProductName,
				                          good.ProductBarcodeType, good.ProductQuantityCounted, good.ProductQuantityFromDatabase,
				                          good.ProductQuantityFromBeginning, good.ProductAddedClient, good.ProductModifiedClient,
				                          good.ProductDateAdded, good.ProductDateModified);
			}

			foreach (var bad in _localRepository.GetAllBadProducts(sessionId))
			{
				dataGridViewBad.Rows.Add(bad.ProductId, bad.ProductDirtyBarcode, bad.ProductCleanBarcode, bad.ProductBarcodeType,
				                         bad.ProductQuantityCounted, bad.ProductConnectedWithProduct, bad.ProductClientAdded,
				                         bad.ProductClientConnected, bad.ProductDateAdded, bad.ProductDateConnected);
			}

			_backgroundWcf.SynchronizeWithClients = true;
			_backgroundWcf.SessionId = sessionId;
		}

		private void ButtonDeleteAllHistorySessionsClick(object sender, EventArgs e)
		{
			_localRepository.RemoveAllData();
			listBoxSessionHistory.Items.Clear();
			_localRepository.CreateSession(DateTime.Now);

			foreach (var session in _localRepository.GetAllSessions())
			{
				listBoxSessionHistory.Items.Add(string.Format("({0}) - {1}", session.ID, session.DateAdded));
			}

			if (listBoxSessionHistory.Items.Count > 0)
			{
				listBoxSessionHistory.SelectedIndex = 0;
			}
		}
	}
}
