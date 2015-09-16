using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PharmacyConditionClient
{
	public partial class AddPartialQuantity : Form
	{
		public double ReturnCalculations { set; get; }

		public AddPartialQuantity()
		{
			InitializeComponent();
		}

		private void AddPartialQuantityShown(object sender, EventArgs e)
		{
			comboBoxTypeOfCalculation.SelectedIndex = 0;
			textBoxCalculating.Focus();
		}

		private void ButtonAddClick(object sender, EventArgs e)
		{
			CheckComboBox();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void TextBoxCalculatingTextChanged(object sender, EventArgs e)
		{
			var textBox = (TextBox) sender;
			buttonAdd.Enabled = textBox.Text.Length > 0;
		}

		private void TextBoxCalculatingKeyPress(object sender, KeyPressEventArgs e)
		{
			Console.WriteLine(comboBoxTypeOfCalculation.SelectedIndex);
			if (e.KeyChar != (char) Keys.Enter) return;

			CheckComboBox();
		}

		private void CheckComboBox()
		{
			switch (comboBoxTypeOfCalculation.SelectedIndex)
			{
				case 0: //opak.
					GetPartialPackages();
					break;

				case 1: //tabl.
					GetPartialTablets();
					break;
			}
		}

		private void GetPartialTablets()
		{
			var regexTablets = new Regex(@"(?<first>\d+)/(?<second>\d+)");
			var resultTablets = regexTablets.Match(textBoxCalculating.Text);

			var firstStringTablets = resultTablets.Groups["first"].Value;
			var secondStringTablets = resultTablets.Groups["second"].Value;

			if (string.IsNullOrEmpty(firstStringTablets) || string.IsNullOrEmpty(secondStringTablets))
			{
				MessageForm.ShowErrorMessage("Błędny zapis wartości!\r\nPoprawny zapis: np. 23\\34");
			}
			else
			{
				try
				{
					var first = Convert.ToInt32(firstStringTablets);
					var second = Convert.ToInt32(secondStringTablets);

					if (first == 0 || second == 0)
					{
						throw new Exception();
					}
					if (first >= second)
					{
						throw new Exception();
					}

					ReturnCalculations = first/(double) second;

					DialogResult = DialogResult.OK;
					Close();
				}
				catch (Exception)
				{
					MessageForm.ShowErrorMessage("Błędnie wprowadzone znaki!\r\n\r\n" +
					                             "Warunki:\r\n" +
					                             "- podane znaki muszą być liczbami\r\n" +
					                             "- pierwsza i ostatnia liczba nie może być zerem\r\n" +
					                             "- pierwsza liczba nie może być większa od drugiej ani równa jej\r\n");
				}
			}
		}

		private void GetPartialPackages()
		{
			var regexPackages = new Regex(@"(?<first>\d+)[,.](?<second>\d+)");
			var resultPackages = regexPackages.Match(textBoxCalculating.Text);

			var firstStringPackages = resultPackages.Groups["first"].Value;
			var secondStringPackages = resultPackages.Groups["second"].Value;

			if (string.IsNullOrEmpty(firstStringPackages) || string.IsNullOrEmpty(secondStringPackages))
			{
				MessageForm.ShowErrorMessage("Błędny zapis wartości!\r\nPoprawny zapis: np. 0,34 lub 0.45");
			}
			else
			{
				try
				{
					var first = Convert.ToInt32(firstStringPackages);
					var second = Convert.ToInt32(secondStringPackages);

					if (first > 0 || second == 0)
					{
						throw new Exception();
					}

					ReturnCalculations = Convert.ToDouble(string.Format("{0},{1}", first, second));

					DialogResult = DialogResult.OK;
					Close();
				}
				catch (Exception)
				{
					MessageForm.ShowErrorMessage("Błędnie wprowadzone znaki!\r\n\r\n" +
					                             "Warunki:\r\n" +
					                             "- podane znaki muszą być liczbami\r\n" +
					                             "- pierwsza i ostatnia liczba, po przecinku (lub kropce) nie może być zerem (np. 0.0 - błąd)\r\n");
				}
			}
		}
	}
}
