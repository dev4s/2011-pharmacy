using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyDelivery
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainWindowLoad(object sender, EventArgs e)
		{
			ChangeDataSource();
			dataGridView1.Rows[0].Selected = true;
		}

		private void ChangeDataSource()
		{
			invoiceBindingSource.DataSource = checkBox1.Checked
			                                  	? DatabasePoco.Invoice.Instance
			                                  	: DatabasePoco.Invoice.Instance.Where(x => x.Checked == false);
		}

		private void Button2Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Button1Click(object sender, EventArgs e)
		{
			var invoiceSelected = (DatabasePoco.Invoice)dataGridView1.SelectedRows[0].DataBoundItem;
			var invoiceItemsForm = new InvoiceItemsForm(invoiceSelected, this);
			invoiceItemsForm.Show();
		}

		private void Button3Click(object sender, EventArgs e)
		{
			var settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//Własny icomparer
			//TODO: Sort - later
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			ChangeDataSource();
		}
	}
}
