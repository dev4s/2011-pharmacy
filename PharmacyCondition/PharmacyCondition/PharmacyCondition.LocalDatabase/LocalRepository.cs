using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyCondition.LocalDatabase
{
	public class LocalRepository
	{
		private readonly LocalDatabaseEntities _repo;
		private Session _session;

		public LocalRepository()
		{
			_repo = new LocalDatabaseEntities();
		}

		public void CreateSession(DateTime date)
		{
			_session = new Session
						{
							DateAdded = date
						};
			_repo.Sessions.AddObject(_session);
			_repo.SaveChanges();
		}

		public void RemoveAllData()
		{
			var tempBad = _repo.BadProducts;
			foreach (var bad in tempBad)
			{
				_repo.BadProducts.DeleteObject(bad);
			}

			var tempGood = _repo.GoodProducts;
			foreach (var good in tempGood)
			{
				_repo.GoodProducts.DeleteObject(good);
			}

			var tempSession = _repo.Sessions;
			foreach (var session in tempSession)
			{
				_repo.Sessions.DeleteObject(session);
			}

			_repo.SaveChanges();
		}

		public IEnumerable<Session> GetAllSessions()
		{
			return new List<Session>(_repo.Sessions);
		}

		public IEnumerable<BadProduct> GetAllBadProducts(string sessionId)
		{
			var guid = new Guid(sessionId);
			return new List<BadProduct>(from bad in _repo.BadProducts 
										where bad.SessionID == guid
										select bad);
		}

		public IEnumerable<GoodProduct> GetAllGoodProducts(string sessionId)
		{
			var guid = new Guid(sessionId);
			return new List<GoodProduct>(from good in _repo.GoodProducts
										 where good.SessionID == guid
										 select good);
		}

		public void AddGoodProduct(int id, string dirtyBarcode, string cleanBarcode, string name, 
								   string typeName, int i, double quantity, double d, string format, 
								   string s, DateTime now, DateTime dateTime)
		{
			var newGoodProduct = new GoodProduct
			{
				SessionID = _session.ID,
				ProductID = id.ToString(),
				ProductDirtyBarcode = dirtyBarcode,
				ProductCleanBarcode = cleanBarcode,
				ProductName = name,
				ProductBarcodeType = typeName,
				ProductQuantityCounted = i.ToString(),
				ProductQuantityFromDatabase = quantity.ToString(),
				ProductQuantityFromBeginning = d.ToString(),
				ProductAddedClient = format,
				ProductModifiedClient = s,
				ProductDateAdded = now.ToString(),
				ProductDateModified = dateTime.ToString(),
			};
			_repo.GoodProducts.AddObject(newGoodProduct);
			_repo.SaveChanges();
		}

		public void AddBadProduct(int id, string dirtyBarcode, string cleanBarcode, string typeName, 
								  int i, string empty, string format, string s, DateTime now, string dateConn)
		{
			var newBadProduct = new BadProduct
			{
				SessionID = _session.ID,
				ProductId = id.ToString(),
				ProductDirtyBarcode = dirtyBarcode,
				ProductCleanBarcode = cleanBarcode,
				ProductBarcodeType = typeName,
				ProductQuantityCounted = i.ToString(),
				ProductConnectedWithProduct = empty,
				ProductClientAdded = format,
				ProductClientConnected = s,
				ProductDateAdded = now.ToString(),
				ProductDateConnected = dateConn
			};
			_repo.BadProducts.AddObject(newBadProduct);
			_repo.SaveChanges();
		}

		public void ChangeGoodProduct(int id, string dirtyBarcode, string cleanBarcode, string name, 
									  string typeName, double qCountedFromRow, double qFromDatabase, 
									  object qBegginingFromRow, object clientAdded, string format, 
									  object dateAdded, DateTime now)
		{
			var goodProduct = (from g in _repo.GoodProducts
			                  where g.ProductDirtyBarcode == dirtyBarcode
			                  select g).Single();

			goodProduct.ProductID = id.ToString();
			goodProduct.ProductCleanBarcode = cleanBarcode;
			goodProduct.ProductName = name;
			goodProduct.ProductBarcodeType = typeName;
			goodProduct.ProductQuantityCounted = qCountedFromRow.ToString();
			goodProduct.ProductQuantityFromDatabase = qFromDatabase.ToString();
			goodProduct.ProductQuantityFromBeginning = qBegginingFromRow.ToString();
			goodProduct.ProductAddedClient = clientAdded.ToString();
			goodProduct.ProductModifiedClient = format;
			goodProduct.ProductDateAdded = dateAdded.ToString();
			goodProduct.ProductModifiedClient = now.ToString();

			_repo.SaveChanges();
		}

		public void ChangeBadProduct(int id, string dirtyBarcode, string cleanBarcode, string typeName, 
									 double d, object connectedWithProduct, object clientAdded, 
									 object clientConnected, object dateAdded, object dateConnected)
		{
			var badProduct = (from g in _repo.BadProducts
							  where g.ProductDirtyBarcode == dirtyBarcode
							  select g).Single();

			badProduct.ProductId = id.ToString();
			badProduct.ProductCleanBarcode = cleanBarcode;
			badProduct.ProductBarcodeType = typeName;
			badProduct.ProductQuantityCounted = d.ToString();
			badProduct.ProductConnectedWithProduct = connectedWithProduct.ToString();
			badProduct.ProductClientAdded = clientAdded.ToString();
			badProduct.ProductClientConnected = clientConnected.ToString();
			badProduct.ProductDateAdded = dateAdded.ToString();
			badProduct.ProductDateConnected = dateConnected.ToString();

			_repo.SaveChanges();
		}

		public void UpdateGoodQuantity(string dirtyBarcode, double quantityGood)
		{
			var goodProduct = (from g in _repo.GoodProducts
							   where g.ProductDirtyBarcode == dirtyBarcode
							   select g).Single();

			goodProduct.ProductQuantityCounted = quantityGood.ToString();

			_repo.SaveChanges();
		}

		public void UpdateBadQuantity(string dirtyBarcode, double quantityBad)
		{
			var badProduct = (from g in _repo.BadProducts
							  where g.ProductDirtyBarcode == dirtyBarcode
							  select g).Single();

			badProduct.ProductQuantityCounted = quantityBad.ToString();

			_repo.SaveChanges();
		}
	}

	public partial class Session
	{
		public Session()
		{
			ID = Guid.NewGuid();
		}
	}

	public partial class BadProduct
	{
		public BadProduct()
		{
			ID = Guid.NewGuid();
		}
	}

	public partial class GoodProduct
	{
		public GoodProduct()
		{
			ID = Guid.NewGuid();
		}
	}
}
