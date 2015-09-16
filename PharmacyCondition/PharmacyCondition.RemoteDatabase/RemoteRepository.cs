using System;
using System.Data;
using System.Linq;

namespace PharmacyCondition.RemoteDatabase
{
	public class RemoteRepository
	{
		private readonly RemoteDatabaseEntities _remoteDatabase;
		
		public int PharmacyId { set; private get; }

		public RemoteRepository(string serverIp, int serverPort, string databaseName, string username, string password)
		{
			var connectionString = ConnectionString(serverIp, serverPort, databaseName, username, password);
			_remoteDatabase = new RemoteDatabaseEntities(connectionString);
		}

		private static string ConnectionString(string serverIp, int serverPort, string databaseName, 
											   string username, string password)
		{
			return string.Format("metadata=res://*/RemoteDatabase.csdl|res://*/RemoteDatabase.ssdl|res://*/RemoteDatabase.msl;" +
								 "provider=FirebirdSql.Data.FirebirdClient;" +
								 "provider connection string=\'timeout=240;port number={0};" +
								 "data source={1};initial catalog={2};user id={3};password={4}\'",
								 serverPort,
								 serverIp,
								 databaseName,
								 username,
								 password);
		}

		public static bool IsThisAProperConnection(string serverIp, int serverPort, string databaseName,
												   string username, string password)
		{
			bool result;
			var testConnectionString = ConnectionString(serverIp, serverPort, databaseName, username, password);

			try
			{
				var testRemote = new RemoteDatabaseEntities(testConnectionString);

				testRemote.Connection.Open();
				result = testRemote.Connection.State == ConnectionState.Open;
				testRemote.Connection.Close();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message, e.InnerException);
			}
			return result;
		}

		public Product FindProduct(string barcode)
		{
			var product = new Product();

			try
			{
				//using delivery code
				var deliveryProduct = (from zk in _remoteDatabase.ZDST_KLAS.Include("ZDST.TOWARY")
									   where zk.ID_KLASYFIKACJE == 6 
											 && zk.WARTOSC == barcode
											 && zk.ID_APTEKI == PharmacyId
									   select new {zk.ZDST.CZYNNY, zk.ZDST.TOWARY.ID_TOWARY, zk.ZDST.TOWARY.NAZWA}).Single();

				product.ID = deliveryProduct.ID_TOWARY;
				product.Name = deliveryProduct.NAZWA;
				product.CleanBarcode = barcode;
				product.BarcodeType = deliveryProduct.CZYNNY == "T" ? BarcodeTypes.Delivery : BarcodeTypes.Selled;
			}
			catch (InvalidOperationException)
			{
				//using EAN
				try
				{
					var tempProduct = (from tw in _remoteDatabase.TOWARY
									   where tw.EAN_REF == barcode 
											 && tw.ID_APTEKI == PharmacyId
									   select new {tw.ID_TOWARY, tw.NAZWA}).Single();

					product.ID = tempProduct.ID_TOWARY;
					product.Name = tempProduct.NAZWA;
					product.CleanBarcode = barcode;
					product.BarcodeType = BarcodeTypes.Ean;
				}
				catch (InvalidOperationException)
				{
					product.ID = 0;
					product.Name = null;
					product.CleanBarcode = barcode;
					product.BarcodeType = BarcodeTypes.NotExisting;
				}
			}

			return product;
		}

		public double GetEanQuantity(int id)
		{
			double quantity;
			try
			{
				quantity = (from zd in _remoteDatabase.ZDST
						   where zd.ID_APTEKI == PharmacyId 
								 && zd.ID_TOWARY == id 
								 && zd.CZYNNY == "T"
						   select zd.STAN).Sum();
			}
			catch (InvalidOperationException)
			{
				quantity = -1;
			}

			if ((int)quantity == 0) 
				return -1;

			return quantity;
		}

		public double GetDeliveryQuantity(string cleanBarcode)
		{
			double quantity;
			try
			{
				quantity = (from zd in _remoteDatabase.ZDST_KLAS.Include("ZDST")
							where zd.ID_APTEKI == PharmacyId
								  && zd.WARTOSC == cleanBarcode
							select zd.ZDST.STAN).Sum();
			}
			catch (InvalidOperationException)
			{
				quantity = -1;
			}

			if ((int) quantity == 0) 
				return -1;

			return quantity;
		}
	}
}