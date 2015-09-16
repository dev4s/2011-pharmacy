using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace PharmacyDelivery
{
	public partial class InvoiceItemsForm : Form
	{
		private readonly MainForm _mainForm;
		private readonly List<DatabasePoco.Item> _invoiceItems;

		private InvoiceItemsForm()
		{
			InitializeComponent();
		}

		public InvoiceItemsForm(DatabasePoco.Invoice invoice, MainForm mainForm) : this()
		{
			_mainForm = mainForm;
			_invoiceItems = invoice.Items.OrderBy(x => x.Name).ToList();
			base.Text += string.Format("{0} ({1})", invoice.Company, invoice.Number);
		}

		private void InvoiceItemsFormFormClosing(object sender, FormClosingEventArgs e)
		{
			_mainForm.Show();
		}

		private void Button1Click(object sender, System.EventArgs e)
		{
			Close();
			_mainForm.Show();
		}

		private void InvoiceItemsFormLoad(object sender, System.EventArgs e)
		{
			_mainForm.Hide();

			itemBindingSource.DataSource = _invoiceItems;

			dataGridView1.AddNewColumn(5, "Stan zliczony", "amountCounted", 0);
			dataGridView1.AddNewColumn(6, "Różnica", "differenceCounted", 0);

			var expirationDateColumn = dataGridView1.Rows;
			foreach (DataGridViewRow row in expirationDateColumn)
			{
				if (((DateTime) row.Cells["ExpirationDate"].Value) <= DateTime.Now)
				{
					row.Cells["ExpirationDate"].Style.ForeColor = Color.DarkRed;
					row.Cells["ExpirationDate"].Style.SelectionForeColor = Color.DarkRed;
				}
			}
			dataGridView1.Update();
		}

		private void Button2Click(object sender, System.EventArgs e)
		{
			var reportForm = new ReportForm();
			reportForm.ShowDialog();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("test");
		}

		private void InvoiceItemsForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F2:
					var selectedItem = dataGridView1.SelectedRows[0];
					var itemForm = new ItemForm((string)selectedItem.Cells["nameDataGridViewTextBoxColumn"].Value, (string)selectedItem.Cells["eanNumberDataGridViewTextBoxColumn"].Value);
					itemForm.ShowDialog();
					break;
			}
		}
	}
}
