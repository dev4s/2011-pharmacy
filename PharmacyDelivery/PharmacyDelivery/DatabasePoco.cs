using System;
using System.Collections.Generic;

namespace PharmacyDelivery
{
	public class DatabasePoco
	{
		public class Invoice
		{
			private static List<Invoice> _invoiceInstace;

			public string Number { get; set; }
			public DateTime DateAdded { get; set; }
			public string Company { get; set; }
			public List<Item> Items { get; set; }
			public bool Checked { get; set; }

			private Invoice () {}

			public static List<Invoice> Instance
			{
				get
				{
					if (_invoiceInstace == null)
					{
						var items1 = new List<Item>
					             	{
					             		new Item { ActualAmount = 23, EanNumber = "1234567890123", Name = "Product 02", 
											ExpirationDate = DateTime.Now.AddMonths(18), Price = 12.23 },
										new Item { ActualAmount = 120, EanNumber = "2345678901234", Name = "Product 01", 
											ExpirationDate = DateTime.Now.AddMonths(-5), Price = 345.66 },
										new Item { ActualAmount = 230, EanNumber = "3456789012345", Name = "Product 03", 
											ExpirationDate = DateTime.Now.AddMonths(13), Price = 1.99 },
					             	};

						var items2 = new List<Item>
					             	{
					             		new Item { ActualAmount = 400, EanNumber = "4567890123456", Name = "Product 05", 
											ExpirationDate = DateTime.Now.AddMonths(40), Price = 3.44 },
										new Item { ActualAmount = 10, EanNumber = "5678901234567", Name = "Product 04", 
											ExpirationDate = DateTime.Now.AddMonths(-20), Price = 3.99 },
										new Item { ActualAmount = 19, EanNumber = "6789012345678", Name = "Product 06", 
											ExpirationDate = DateTime.Now.AddMonths(10), Price = 5.49 },
					             	};

						_invoiceInstace = new List<Invoice>
										{
											new Invoice { Company = "PharmacyName 1", DateAdded = DateTime.Now.AddMonths(-2), 
												Number = "FV/23/01/2011", Items = items1, Checked = false },
											new Invoice { Company = "PharmacyName 2", DateAdded = DateTime.Now.AddMonths(-1), 
												Number = "FV/12/01/2011", Items = items2, Checked = true },
											new Invoice { Company = "PharmacyName 3", DateAdded = DateTime.Now.AddMonths(-4), 
												Number = "FV/01/01/2011", Items = items1, Checked = true },
											new Invoice { Company = "PharmacyName 4", DateAdded = DateTime.Now.AddMonths(-3), 
												Number = "FV/23/02/2011", Items = items2, Checked = false },
										};
					}

					return _invoiceInstace;
				}
			}
		}

		public class Item
		{
			public string Name { get; set; }
			public string EanNumber { get; set; }
			public int ActualAmount { get; set; }
			public DateTime ExpirationDate { get; set; }
			public double Price { get; set; }
		}
	}
}