using System.Collections.Generic;
using System.ServiceModel;
using PharmacyCondition.RemoteDatabase;

namespace PharmacyCondition.Services
{
	[ServiceContract]
	public interface IProductService
	{
		[OperationContract] bool IsServerRunning();
		[OperationContract] bool GetSynchronizeWithServer();
		[OperationContract] void SetSynchronizeWithServer(bool value);
		[OperationContract] IEnumerable<ClientData> GetClientList();
		[OperationContract] void SendClientName(string name);
		[OperationContract] Product FindProductOnServer(string dirtyBarcode, string prefix, string clientName, string clientGuid);
		[OperationContract] void IncreaseQuantityRowOnServer(string dirtyBarcode, string prefix, string clientName, string clientGuid);
		[OperationContract] void DecreaseQuantityRowOnServer(string dirtyBarcode, string prefix, string clientName, string clientGuid);
		[OperationContract] void AddPartialQuantityRowOnServer(string dirtyBarcode, double partialQuantity, 
															   string prefix, string clientName, string clientGuid);
		[OperationContract] void ClientConnectedToServer(string clientName, string clientGuid);
		[OperationContract] void ClientDisconnectedToServer(string clientName, string clientGuid);
	}
}