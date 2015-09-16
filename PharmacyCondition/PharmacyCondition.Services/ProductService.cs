using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using PharmacyCondition.RemoteDatabase;

namespace PharmacyCondition.Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IncludeExceptionDetailInFaults = true)]
	public class ProductService : IProductService
	{
		private readonly RemoteRepository _repo;
		private readonly Queue<BackgroundServerEventStack> _backgroundServerMessageStack = new Queue<BackgroundServerEventStack>();
		private List<ClientData> _clientDatas;
		private static bool _synchronize;
		private static string _clientName;

		public ProductService(int pharmacyId, string serverIp, int serverPort, string databaseName, string username, string password)
		{
			_repo = new RemoteRepository(serverIp, serverPort, databaseName, username, password) {PharmacyId = pharmacyId};
		}

		#region Interface implementation
		public bool IsServerRunning()
		{
			return true;
		}

		public void SetSynchronizeWithServer(bool value)
		{
			_synchronize = value;
		}

		public bool GetSynchronizeWithServer()
		{
			return _synchronize;
		}

		public IEnumerable<ClientData> GetClientList()
		{
			return _clientDatas;
		}

		public void SendClientName(string name)
		{
			_clientName = name;
		}

		public Product FindProductOnServer(string dirtyBarcode, string prefix, string clientName, string clientGuid)
		{
			var product = FindProduct(dirtyBarcode, prefix);
			EnqueueBackgroundServerEventStack(BackgroundServerEventCommands.FindProduct, product, null, null, prefix, clientName, clientGuid);

			return product;
		}

		public void IncreaseQuantityRowOnServer(string dirtyBarcode, string prefix, string clientName, string clientGuid)
		{
			EnqueueBackgroundServerEventStack(BackgroundServerEventCommands.IncreaseQuantity, null, dirtyBarcode, null, prefix, clientName, clientGuid);
		}

		public void DecreaseQuantityRowOnServer(string dirtyBarcode, string prefix, string clientName, string clientGuid)
		{
			EnqueueBackgroundServerEventStack(BackgroundServerEventCommands.DecreaseQuantity, null, dirtyBarcode, null, prefix, clientName, clientGuid);
		}

		public void AddPartialQuantityRowOnServer(string dirtyBarcode, double partialQuantity, string prefix, string clientName, string clientGuid)
		{
			EnqueueBackgroundServerEventStack(BackgroundServerEventCommands.AddPartialQuantity, null, dirtyBarcode, 
											  partialQuantity.ToString(), prefix, clientName, clientGuid);
		}

		public void ClientConnectedToServer(string clientName, string clientGuid)
		{
			EnqueueBackgroundServerEventStack(BackgroundServerEventCommands.ClientConnect, null, null, null, null, clientName, clientGuid);
		}

		public void ClientDisconnectedToServer(string clientName, string clientGuid)
		{
			EnqueueBackgroundServerEventStack(BackgroundServerEventCommands.ClientDisconnect, null, null, null, null, clientName, clientGuid);
		}
		#endregion

		#region Used in ProductService
		private Product FindProduct(string dirtyBarcode, string prefix)
		{
			var cleanedBarcode = dirtyBarcode.MakeItClean(prefix);
			var product = _repo.FindProduct(cleanedBarcode);
			product.DirtyBarcode = dirtyBarcode;

			return product;
		}

		private void EnqueueBackgroundServerEventStack(BackgroundServerEventCommands eventCommand, Product product,
													   string firstEvent, string secondEvent,
													   string prefix, 
													   string clientName, string clientGuid)
		{
			_backgroundServerMessageStack.Enqueue(new BackgroundServerEventStack
			                                      	{
			                                      		Product = product,
														EventCommand = eventCommand,
														FirstEvent = firstEvent,
														SecondEvent = secondEvent,
														Prefix = prefix,
			                                      		ClientGuid = clientGuid,
			                                      		ClientName = clientName
			                                      	});
		}
		#endregion

		#region For server only
		public void SetClientList(List<ClientData> clientDatas)
		{
			_clientDatas = clientDatas;
		}

		public static string GetClientName()
		{
			return _clientName;
		}

		public double GetEanQuantity(int id)
		{
			return _repo.GetEanQuantity(id);
		}

		public double GetDeliveryQuantity(string cleanBarcode)
		{
			return _repo.GetDeliveryQuantity(cleanBarcode);
		}

		public BackgroundServerEventStack GetBackgroundServerEventStackFromQueue()
		{
			return _backgroundServerMessageStack.Count > 0 ? _backgroundServerMessageStack.Dequeue() : null;
		}

		public int HowManyStackItemsInBackgroundServerEventStackQueue()
		{
			return _backgroundServerMessageStack.Count;
		}
		#endregion
	}

	#region DataContract and BackgroundServerEventStack
	[DataContract]
	public enum BackgroundServerEventCommands
	{
		[EnumMember] FindProduct,
		[EnumMember] IncreaseQuantity,
		[EnumMember] DecreaseQuantity,
		[EnumMember] AddPartialQuantity,
		[EnumMember] ClientConnect,
		[EnumMember] ClientDisconnect
	}

	public class BackgroundServerEventStack
	{
		public Product Product { set; get; }
		public BackgroundServerEventCommands EventCommand { set; get; }

		/// <summary>
		/// Dirty barcode
		/// </summary>
		public string FirstEvent { set; get; }

		/// <summary>
		/// Partial quantity
		/// </summary>
		public string SecondEvent { set; get; }
		public string Prefix { set; get; }
		public string ClientName { set; get; }
		public string ClientGuid { set; get; }
	}
	#endregion

	[DataContract]
	public class ClientData
	{
		[DataMember] public string ID { get; set; }
		[DataMember] public string BarcodeType { get; set; }
		[DataMember] public string DirtyBarcode { get; set; }
		[DataMember] public string CleanBarcode { get; set; }
		[DataMember] public string ProductName { get; set; }
		[DataMember] public string QuantityCount { get; set; }
		[DataMember] public string DateAdded { get; set; }
		[DataMember] public string DateModified { get; set; }
	}
}