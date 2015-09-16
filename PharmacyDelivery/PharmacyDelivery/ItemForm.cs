using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyDelivery
{
	public partial class ItemForm : Form
	{
		private ItemForm()
		{
			InitializeComponent();
		}

		public ItemForm(string name, string ean) : this()
		{
			label4.Text = name;
			label5.Text = ean;
			comboBox1.Items.Add("opak.");
			comboBox1.Items.Add("tabl.");
			comboBox1.SelectedIndex = 0;
		}

		private void ItemForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape:
					Close();
					break;

				case Keys.F2:
					//TODO: send it back...
					break;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//TODO: send it back...
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
