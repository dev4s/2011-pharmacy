using System.Windows.Forms;

namespace PharmacyConditionServer
{
	public static class MessageForm
	{
		public static void ShowErrorMessage(string message)
		{
			ShowErrorMessage(@"Wystąpił nieoczekiwany błąd!",
							 message,
							 MessageBoxIcon.Error);
		}
		
		public static void ShowInformationMessage(string message)
		{
			ShowErrorMessage(@"Informacja",
							 message,
							 MessageBoxIcon.Information);
		}

		private static void ShowErrorMessage(string caption, string message, MessageBoxIcon icon)
		{
			MessageBox.Show(message, 
							caption, 
							MessageBoxButtons.OK, 
							icon, 
							MessageBoxDefaultButton.Button1);
		}
	}
}