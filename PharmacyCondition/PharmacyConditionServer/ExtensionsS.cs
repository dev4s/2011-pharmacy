using System;
using System.ComponentModel;
using System.Windows.Forms;
using PharmacyCondition.LocalDatabase;
using PharmacyCondition.RemoteDatabase;

namespace PharmacyConditionServer
{
	public static class ExtensionsS
	{
		#region Product columns
		private const int ProductIdRow = 0;
		private const int ProductDirtyBarcode = 1;
		private const int ProductCleanBarcode = 2;

		private const int ProductName = 3;
		private const int ProductBarcodeType = 4;
		private const int ProductQuantityCountedRow = 5;

		private const int ProductQuantityFromDatabase = 6;
		private const int ProductQuantityFromBeginning = 7;
		private const int ProductAddedClient = 8;

		private const int ProductModifiedClient = 9;
		private const int ProductDateAdded = 10;
		private const int ProductDateModified = 11;
		#endregion

		#region Not product
		private const int NotProductIdRow = 0;
		private const int NotProductDirtyBarcode = 1;
		private const int NotProductCleanBarcode = 2;

		private const int NotProductBarcodeType = 3;
		private const int NotProductQuantityCountedRow = 4;
		private const int NotProductConnectedWithProduct = 5;

		private const int NotProductClientAdded = 6;
		private const int NotProductClientConnected = 7;
		private const int NotProductDateAdded = 8;

		private const int NotProductDateConnected = 9;
		#endregion

		public static void UpdateGoodRow(this DataGridView dataGridView, Product product, Host host, 
										 string clientName, string clientGuid, LocalRepository localRepository)
		{
			var index = dataGridView.FindRowForGoodProduct(product);
			switch (product.BarcodeType)
			{
				case BarcodeTypes.Delivery:
					if (index == -1) dataGridView.AddNewGoodProductRow(product, host, "Dostawy", clientName, 
																	   clientGuid, localRepository);
					else dataGridView.ChangeExistingGoodProductRow(product, host, index, "Dostawy", clientName, 
																   clientGuid, localRepository);
					break;

				case BarcodeTypes.Ean:
					if (index == -1) dataGridView.AddNewGoodProductRow(product, host, "Produkt", clientName, 
																	   clientGuid, localRepository);
					else dataGridView.ChangeExistingGoodProductRow(product, host, index, "Produkt", clientName, 
																   clientGuid, localRepository);
					break;
			}

			dataGridView.Sort(dataGridView.Columns[ProductDateModified], ListSortDirection.Descending);
		}

		public static void UpdateBadRow(this DataGridView dataGridView, Product product, string clientName, 
										string clientGuid, LocalRepository localRepository)
		{
			var index = dataGridView.FindRowForBadProduct(product);
			switch (product.BarcodeType)
			{
			    case BarcodeTypes.NotExisting:
			        if (index == -1) dataGridView.AddNewBadProductRow(product, "Nie istniejący", clientName, 
																	  clientGuid, localRepository);
			        else dataGridView.ChangeExistingBadProductRow(product, "Nie istniejący", index, localRepository);
			        break;

			    case BarcodeTypes.Selled:
					if (index == -1) dataGridView.AddNewBadProductRow(product, "Sprzedany", clientName, clientGuid, localRepository);
					else dataGridView.ChangeExistingBadProductRow(product, "Sprzedany", index, localRepository);
			        break;
			}

			dataGridView.Sort(dataGridView.Columns[NotProductDateConnected], ListSortDirection.Descending);
		}

		public static void IncreaseQuantityRow(DataGridView dataGridViewGood, DataGridView dataGridViewBad, 
											   string dirtyBarcode, LocalRepository localRepository)
		{
			var indexGood = dataGridViewGood.FindRowForGoodProduct(dirtyBarcode);
			var indexBad = dataGridViewBad.FindRowForBadProduct(dirtyBarcode);

			if (indexGood != -1)
			{
				var quantityGood = Convert.ToDouble(dataGridViewGood.Rows[indexGood].Cells[ProductQuantityCountedRow].Value);
				dataGridViewGood.Rows[indexGood].Cells[ProductQuantityCountedRow].Value = ++quantityGood;

				localRepository.UpdateGoodQuantity(dirtyBarcode, quantityGood);

				return;
			}

			var quantityBad = Convert.ToDouble(dataGridViewBad.Rows[indexBad].Cells[NotProductQuantityCountedRow].Value);
			dataGridViewBad.Rows[indexBad].Cells[NotProductQuantityCountedRow].Value = ++quantityBad;

			localRepository.UpdateBadQuantity(dirtyBarcode, quantityBad);

			return;
		}

		public static bool DecreaseQuantityRow(DataGridView dataGridViewGood, DataGridView dataGridViewBad, 
											   string dirtyBarcode, LocalRepository localRepository)
		{
			var indexGood = dataGridViewGood.FindRowForGoodProduct(dirtyBarcode);
			var indexBad = dataGridViewBad.FindRowForBadProduct(dirtyBarcode);

			if (indexGood != -1)
			{
				var quantityGood = Convert.ToDouble(dataGridViewGood.Rows[indexGood].Cells[ProductQuantityCountedRow].Value);
				if (quantityGood > 0)
				{
					dataGridViewGood.Rows[indexGood].Cells[ProductQuantityCountedRow].Value = --quantityGood;

					localRepository.UpdateGoodQuantity(dirtyBarcode, quantityGood);

					return true;
				}
				return false;
			}

			var quantityBad = Convert.ToDouble(dataGridViewBad.Rows[indexBad].Cells[NotProductQuantityCountedRow].Value);
			if (quantityBad > 0)
			{
				dataGridViewBad.Rows[indexBad].Cells[NotProductQuantityCountedRow].Value = --quantityBad;

				localRepository.UpdateBadQuantity(dirtyBarcode, quantityBad);

				return true;
			}
			return false;
		}

		public static void AddPartialQuantityRow(DataGridView dataGridViewGood, DataGridView dataGridViewBad, 
												 string dirtyBarcode, double partialQuantity, LocalRepository localRepository)
		{
			var indexGood = dataGridViewGood.FindRowForGoodProduct(dirtyBarcode);
			var indexBad = dataGridViewBad.FindRowForBadProduct(dirtyBarcode);

			if (indexGood != -1)
			{
				var quantityGood = Convert.ToDouble(dataGridViewGood.Rows[indexGood].Cells[ProductQuantityCountedRow].Value);
				dataGridViewGood.Rows[indexGood].Cells[ProductQuantityCountedRow].Value = quantityGood + partialQuantity;

				localRepository.UpdateGoodQuantity(dirtyBarcode, quantityGood + partialQuantity);

				return;
			}

			var quantityBad = Convert.ToDouble(dataGridViewBad.Rows[indexBad].Cells[NotProductQuantityCountedRow].Value);
			dataGridViewBad.Rows[indexBad].Cells[NotProductQuantityCountedRow].Value = quantityBad + partialQuantity;

			localRepository.UpdateBadQuantity(dirtyBarcode, quantityBad + partialQuantity);

			return;
		}

		private static void AddNewGoodProductRow(this DataGridView dataGridView, Product product, Host host, 
												 string typeName, string clientName, string clientGuid, 
												 LocalRepository localRepository)
		{
			double quantity = 0;
			switch (product.BarcodeType)
			{
				case BarcodeTypes.Ean:
					quantity = host.ProductService.GetEanQuantity(product.ID);
					break;

				case BarcodeTypes.Delivery:
					quantity = host.ProductService.GetDeliveryQuantity(product.CleanBarcode);
					break;
			}

			dataGridView.Rows.Add(product.ID, product.DirtyBarcode, product.CleanBarcode,
								  product.Name, typeName, 1,
								  quantity, quantity, string.Format("{0} ({1})", clientName, clientGuid),
								  string.Format("{0} ({1})", clientName, clientGuid), DateTime.Now, DateTime.Now);

			localRepository.AddGoodProduct(product.ID, product.DirtyBarcode, product.CleanBarcode,
													product.Name, typeName, 1,
													quantity, quantity, string.Format("{0} ({1})", clientName, clientGuid),
													string.Format("{0} ({1})", clientName, clientGuid), DateTime.Now, DateTime.Now);
		}

		private static void AddNewBadProductRow(this DataGridView dataGridView, Product product, string typeName, 
												string clientName, string clientGuid, LocalRepository localRepository)
		{
			dataGridView.Rows.Add(product.ID, product.DirtyBarcode, product.CleanBarcode,
								  typeName, 1, "",
								  string.Format("{0} ({1})", clientName, clientGuid), "", DateTime.Now,
								  "");

			localRepository.AddBadProduct(product.ID, product.DirtyBarcode, product.CleanBarcode,
												   typeName, 1, "",
												   string.Format("{0} ({1})", clientName, clientGuid), "", DateTime.Now,
												   "");
		}

		private static void ChangeExistingGoodProductRow(this DataGridView dataGridView, Product product, 
														 Host host, int index, string typeName, string clientName, 
														 string clientGuid, LocalRepository localRepository)
		{
			var qCountedFromRow = Convert.ToDouble(dataGridView.Rows[index].Cells[ProductQuantityCountedRow].Value);
			var qBegginingFromRow = dataGridView.Rows[index].Cells[ProductQuantityFromBeginning].Value;
			var clientAdded = dataGridView.Rows[index].Cells[ProductAddedClient].Value;
			var dateAdded = dataGridView.Rows[index].Cells[ProductDateAdded].Value;

			double qFromDatabase = 0;
			switch (product.BarcodeType)
			{
				case BarcodeTypes.Ean:
					qFromDatabase = host.ProductService.GetEanQuantity(product.ID);
					break;

				case BarcodeTypes.Delivery:
					qFromDatabase = host.ProductService.GetDeliveryQuantity(product.CleanBarcode);
					break;
			}

			dataGridView.Rows[index].SetValues(product.ID, product.DirtyBarcode, product.CleanBarcode,
											   product.Name, typeName, ++qCountedFromRow,
											   qFromDatabase, qBegginingFromRow, clientAdded,
											   string.Format("{0} ({1})", clientName, clientGuid), dateAdded, DateTime.Now);

			localRepository.ChangeGoodProduct(product.ID, product.DirtyBarcode, product.CleanBarcode,
											  product.Name, typeName, qCountedFromRow,
											  qFromDatabase, qBegginingFromRow, clientAdded,
											  string.Format("{0} ({1})", clientName, clientGuid), dateAdded, DateTime.Now);

		}

		private static void ChangeExistingBadProductRow(this DataGridView dataGridView, Product product, 
														string typeName, int index, LocalRepository localRepository)
		{
			var qCountedFromRow = Convert.ToDouble(dataGridView.Rows[index].Cells[NotProductQuantityCountedRow].Value);
			var connectedWithProduct = dataGridView.Rows[index].Cells[NotProductConnectedWithProduct].Value;
			var clientAdded = dataGridView.Rows[index].Cells[NotProductClientAdded].Value;
			var clientConnected = dataGridView.Rows[index].Cells[NotProductClientConnected].Value;
			var dateAdded = dataGridView.Rows[index].Cells[NotProductDateAdded].Value;
			var dateConnected = dataGridView.Rows[index].Cells[NotProductDateConnected].Value;

			dataGridView.Rows[index].SetValues(product.ID, product.DirtyBarcode, product.CleanBarcode,
											   typeName, ++qCountedFromRow, connectedWithProduct,
											   clientAdded, clientConnected, dateAdded,
											   dateConnected);

			localRepository.ChangeBadProduct(product.ID, product.DirtyBarcode, product.CleanBarcode,
			                                 typeName, ++qCountedFromRow, connectedWithProduct,
			                                 clientAdded, clientConnected, dateAdded,
			                                 dateConnected);
		}

		public static void ClientConnected(this ListBox listBox, string clientName, string clientGuid)
		{
			listBox.Items.Add(string.Format("{0} ({1})", clientName, clientGuid));
		}

		public static void ClientDisconnected(this ListBox listBox, string clientName, string clientGuid)
		{
			listBox.Items.Remove(string.Format("{0} ({1})", clientName, clientGuid));
		}

		public static void UpdateLog(this ListBox listBox, string clientName, string clientGuid, string eventMessage, 
									 Product product, string firstEvent)
		{
			if (product != null)
			{
				if (string.IsNullOrEmpty(product.Name))
				{
					listBox.Items.Add(string.Format("({0}) {1} ({2}), wykonał operację: {3}, na: {4} ({5})",
					                                DateTime.Now.ToShortTimeString(),
					                                clientName,
					                                clientGuid,
					                                eventMessage,
					                                "Nie istniejący/sprzedany",
					                                product.CleanBarcode));
				}
				else
				{
					listBox.Items.Add(string.Format("({0}) {1} ({2}), wykonał operację: {3}, na: {4} ",
					                                DateTime.Now.ToShortTimeString(),
					                                clientName,
					                                clientGuid,
					                                eventMessage,
					                                product.Name));
				}
			}
			else
			{
				listBox.Items.Add(string.Format("({0}) {1} ({2}), wykonał operację: {3}, na: {4} ",
													DateTime.Now.ToShortTimeString(),
													clientName,
													clientGuid,
													eventMessage,
													firstEvent));
			}
			listBox.SelectedIndex = listBox.Items.Count - 1;
			listBox.SelectedIndex = -1;
		}

		private static int FindRowForGoodProduct(this DataGridView dataGridView, string dirtyBarcode)
		{
			var index = -1;
			try
			{
				if (dataGridView.Rows.Count > 0)
				{
					foreach (DataGridViewRow row in dataGridView.Rows)
					{
						if (row.Cells[ProductDirtyBarcode].Value.ToString() == dirtyBarcode)
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

		private static int FindRowForBadProduct(this DataGridView dataGridView, string dirtyBarcode)
		{
			var index = -1;
			try
			{
				if (dataGridView.Rows.Count > 0)
				{
					foreach (DataGridViewRow row in dataGridView.Rows)
					{
						if (row.Cells[NotProductDirtyBarcode].Value.ToString() == dirtyBarcode)
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

		private static int FindRowForGoodProduct(this DataGridView dataGridView, Product product)
		{
			var index = -1;
			try
			{
				if (dataGridView.Rows.Count > 0)
				{
					foreach (DataGridViewRow row in dataGridView.Rows)
					{
						if (row.Cells[ProductIdRow].Value.ToString() == product.ID.ToString() &&
							row.Cells[ProductDirtyBarcode].Value.ToString() == product.DirtyBarcode)
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
		
		private static int FindRowForBadProduct(this DataGridView dataGridView, Product product)
		{
			var index = -1;
			try
			{
				if (dataGridView.Rows.Count > 0)
				{
					foreach (DataGridViewRow row in dataGridView.Rows)
					{
						if (row.Cells[NotProductIdRow].Value.ToString() == product.ID.ToString() &&
							row.Cells[NotProductDirtyBarcode].Value.ToString() == product.DirtyBarcode)
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