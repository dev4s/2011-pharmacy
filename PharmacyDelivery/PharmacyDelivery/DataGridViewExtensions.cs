using System.Windows.Forms;

namespace PharmacyDelivery
{
	static class DataGridViewExtensions
	{
		public static void AddNewColumn(this DataGridView dataGridView, int position, string headerText, string name, object defaultValue)
		{
			var newColumn = new DataGridViewTextBoxColumn() { HeaderText = headerText, Name = name };

			dataGridView.Columns.Insert(position, newColumn);
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				row.Cells[name].Value = defaultValue;
			}
		}
	}
}
