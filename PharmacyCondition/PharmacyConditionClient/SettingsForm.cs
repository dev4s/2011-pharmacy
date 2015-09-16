using System;
using System.Windows.Forms;
using PharmacyConditionClient.Properties;

namespace PharmacyConditionClient
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsFormShown(object sender, EventArgs e)
		{
			textBoxComputerName.Text = Settings.Default.ComputerName;
			textBoxServerIp.Text = Settings.Default.ServerIp;
			textBoxServerPort.Text = Settings.Default.ServerPort.ToString();
			checkBoxPrefix.Checked = Settings.Default.PrefixEnabled;
			if (checkBoxPrefix.Checked)
			{
				textBoxPrefix.Enabled = true;
				textBoxPrefix.Text = Settings.Default.Prefix == ' ' ? "" : Settings.Default.Prefix.ToString();
			}
			else
			{
				textBoxPrefix.Text = "";
				textBoxPrefix.Enabled = false;
			}
		}

		private void ButtonSaveClick(object sender, EventArgs e)
		{
			bool errorsOnForm;

			Settings.Default.ComputerName = textBoxComputerName.Text;
			Settings.Default.ServerIp = textBoxServerIp.Text;
			try
			{
				Settings.Default.ServerPort = Convert.ToInt32(textBoxServerPort.Text);
			}
			catch(Exception)
			{
				Settings.Default.ServerPort = 3000;
			}
			Settings.Default.PrefixEnabled = checkBoxPrefix.Checked;

			if (string.IsNullOrWhiteSpace(textBoxPrefix.Text) && checkBoxPrefix.Checked)
			{
				errorsOnForm = true;
				MessageForm.ShowErrorMessage("Wprowadź prefix!");
			}
			else
			{
				errorsOnForm = false;
				if (!string.IsNullOrWhiteSpace(textBoxPrefix.Text))
				{
					Settings.Default.Prefix = Convert.ToChar(textBoxPrefix.Text);
				}
			}
			if (errorsOnForm) return;
			Settings.Default.Save();
			Close();
		}

		private void CheckBoxPrefixCheckStateChanged(object sender, EventArgs e)
		{
			var checkBox = (CheckBox) sender;

			switch (checkBox.CheckState)
			{
				case CheckState.Checked:
					textBoxPrefix.Enabled = true;
					break;

				case CheckState.Unchecked:
					textBoxPrefix.Enabled = false;
					break;
			}
		}

		private void ButtonConnectionTestClick(object sender, EventArgs e)
		{
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			buttonConnectionTest.Enabled = false;
			ControlBox = false;

			var client = new Client();
			client.Open();

			try
			{
				client.Channel.IsServerRunning();
				MessageForm.ShowInformationMessage("Połączenie jest poprawne");
			}
			catch (Exception ex)
			{
				var basicError = "Wystąpił błąd połączenia.\r\n" +
								 "Serwer nie odpowiada.\r\n\r\n" +
								 "Szczegóły błędu:\r\n" +
								 ex.Message;

				if (ex.InnerException == null)
				{
					MessageForm.ShowErrorMessage(basicError);
				}
				else
				{
					MessageForm.ShowErrorMessage(basicError + "\r\n" + ex.InnerException.Message);
				}
			}

			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			buttonConnectionTest.Enabled = true;
			ControlBox = true;
		}
	}
}
