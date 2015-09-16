using System;
using System.ComponentModel;
using System.Windows.Forms;
using PharmacyCondition.RemoteDatabase;

namespace PharmacyConditionClient
{
	public static class ExtensionsC
	{
		private const int IdRow = 0;
		private const int BarcodeType = 1;
		private const int DirtyBarcodeRow = 2;
		private const int CleanBarcodeRow = 3;
		private const int ProductName = 4;
		private const int QuantityCountRow = 5;
		private const int DateAddedRow = 6;
		private const int DateModifiedRow = 7;

		public static void UpdateRow(this DataGridView dataGridView, Product product)
		{
			var index = dataGridView.FindRowForProduct(product);

			switch (product.BarcodeType)
			{
				case BarcodeTypes.Delivery:
				case BarcodeTypes.Ean:
					if (index == -1) dataGridView.AddNewProductRow(null, product);
					else dataGridView.ChangeExistingProductRow(index, null, product);
					break;

				case BarcodeTypes.NotExisting:
					if (index == -1) dataGridView.AddNewProductRow("Błąd - Nie istniejący", product);
					else dataGridView.ChangeExistingProductRow(index, "Błąd - Nie istniejący", product);
					break;

				case BarcodeTypes.Selled:
					if (index == -1) dataGridView.AddNewProductRow("Błąd - Sprzedany", product);
					else dataGridView.ChangeExistingProductRow(index, "Błąd - Sprzedany", product);
					break;
			}

			dataGridView.Sort(dataGridView.Columns[DateModifiedRow], ListSortDirection.Descending);
		}

		public static void IncreaseQuantityRow(this DataGridView dataGridView)
		{
			var quantity = Convert.ToDouble(dataGridView.SelectedRows[0].Cells[QuantityCountRow].Value);
			dataGridView.SelectedRows[0].Cells[QuantityCountRow].Value = ++quantity;
		}

		public static void DecreaseQuantityRow(this DataGridView dataGridView)
		{
			var quantity = Convert.ToDouble(dataGridView.SelectedRows[0].Cells[QuantityCountRow].Value);

			if (quantity > 0)
			{
				dataGridView.SelectedRows[0].Cells[QuantityCountRow].Value = --quantity;
			}
		}

		public static void AddPartialQuantityRow(this DataGridView dataGridView, double partialQuantity)
		{
			var quantity = Convert.ToDouble(dataGridView.SelectedRows[0].Cells[QuantityCountRow].Value);

			dataGridView.SelectedRows[0].Cells[QuantityCountRow].Value = quantity + partialQuantity;
		}

		private static void AddNewProductRow(this DataGridView dataGridView, string typeName, Product product)
		{
			var productName = String.IsNullOrEmpty(typeName) ? product.Name : typeName;

			dataGridView.Rows.Add(product.ID, product.BarcodeType, 
								  product.DirtyBarcode, product.CleanBarcode, 
								  productName, 1, 
								  DateTime.Now, DateTime.Now);
		}

		private static void ChangeExistingProductRow(this DataGridView dataGridView, int index, string typeName, Product product)
		{
			var quantityFromRow = (int) dataGridView.Rows[index].Cells[QuantityCountRow].Value;
			var dateAddedFromRow = (DateTime) dataGridView.Rows[index].Cells[DateAddedRow].Value;
			var productName = String.IsNullOrEmpty(typeName) ? product.Name : typeName;

			dataGridView.Rows[index].SetValues(product.ID, product.BarcodeType, 
											   product.DirtyBarcode, product.CleanBarcode, 
											   productName, ++quantityFromRow,
											   dateAddedFromRow, DateTime.Now);
		}

		private static int FindRowForProduct(this DataGridView dataGridView, Product product)
		{
			var index = -1;
			try
			{
				if (dataGridView.Rows.Count > 0)
				{
					foreach (DataGridViewRow row in dataGridView.Rows)
					{
						if (row.Cells[IdRow].Value.ToString() == product.ID.ToString() &&
							row.Cells[CleanBarcodeRow].Value.ToString() == product.CleanBarcode)
						{
							index = row.Index;
						}
					}
				}
			}
			catch (InvalidOperationException)
			{
				index = -1;
			}

			return index;
		}
	}
}