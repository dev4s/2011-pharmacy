using System;
using System.Windows.Forms;
using PharmacyCondition.RemoteDatabase;
using PharmacyConditionServer.Properties;

namespace PharmacyConditionServer
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsFormShown(object sender, EventArgs e)
		{
			textBoxDbServerIp.Text = Settings.Default.DBServerIp;
			textBoxDbPort.Text = Settings.Default.DBServerPort.ToString();
			textBoxDbName.Text = Settings.Default.DBName;
			textBoxDbUsername.Text = Settings.Default.DBUsername;
			textBoxDbPassword.Text = Password.Decrypt(Settings.Default.DBPassword);
			textBoxDbPharmacyId.Text = Settings.Default.DBPharmacyId.ToString();

			checkBoxShowPassword.CheckState = Settings.Default.DBPasswordShowOnForm;
			textBoxDbPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;

			textBoxServerIp.Text = Settings.Default.ServerIp;
			textBoxServerPort.Text = Settings.Default.ServerPort.ToString();
		}

		private void CheckBoxShowPasswordCheckedChanged(object sender, EventArgs e)
		{
			var checkBox = (CheckBox) sender;
			textBoxDbPassword.UseSystemPasswordChar = !checkBox.Checked;
		}

		private void ButtonConnectionTestClick(object sender, EventArgs e)
		{
			EnabledOnControlForms(false);

			bool result;
			try
			{
				result = RemoteRepository.IsThisAProperConnection(textBoxDbServerIp.Text,
				                                            Convert.ToInt32(textBoxDbPort.Text),
				                                            textBoxDbName.Text,
				                                            textBoxDbUsername.Text,
				                                            textBoxDbPassword.Text);
			}
			catch(Exception ex)
			{
				ShowConnectionError(ex);
				EnabledOnControlForms(true);
				return;
			}

			if (result)
			{
				ShowConnectionGood();
				SetDbSettings();

				Settings.Default.Save();
			}
			else
			{
				ShowConnectionError(null);
			}

			EnabledOnControlForms(true);
		}

		private static void ShowConnectionGood()
		{
			MessageForm.ShowInformationMessage("Wprowadzone dane są poprawne.");
		}

		private static void ShowConnectionError(Exception e)
		{
			if (e == null)
			{
				MessageForm.ShowErrorMessage("Zostały błędnie wprowadzone dane połączenia.\r\n");
			}
			else
			{
				MessageForm.ShowErrorMessage("Zostały błędnie wprowadzone dane połączenia.\r\n" +
							"Proszę popraw je.\r\n\r\n" +
							e.Message +
							"\r\n" +
							e.InnerException.Message);
			}
		}

		private void ButtonSaveClick(object sender, EventArgs e)
		{
			SetDbSettings();
			Settings.Default.ServerIp = textBoxServerIp.Text;
			try
			{
				Settings.Default.ServerPort = Convert.ToInt32(textBoxServerPort.Text);
			}
			catch(Exception)
			{
				Settings.Default.ServerPort = 3000;
			}
			
			Settings.Default.Save();
			Close();
		}

		private void SetDbSettings()
		{
			Settings.Default.DBServerIp = textBoxDbServerIp.Text;
			try
			{
				Settings.Default.DBServerPort = Convert.ToInt32(textBoxDbPort.Text);
			}
			catch (Exception)
			{
				Settings.Default.DBServerPort = 3050;
			}
			Settings.Default.DBName = textBoxDbName.Text;
			Settings.Default.DBUsername = textBoxDbUsername.Text;
			Settings.Default.DBPasswordShowOnForm = checkBoxShowPassword.CheckState;
			Settings.Default.DBPassword = Password.Encrypt(textBoxDbPassword.Text);
			try
			{
				Settings.Default.DBPharmacyId = Convert.ToInt32(textBoxDbPharmacyId.Text);
			}
			catch (Exception)
			{
				Settings.Default.DBPharmacyId = 10000;
			}
		}

		private void EnabledOnControlForms(bool value)
		{
			buttonConnectionTest.Enabled = value;
			buttonCancel.Enabled = value;
			buttonSave.Enabled = value;
			ControlBox = value;
		}
	}
}
