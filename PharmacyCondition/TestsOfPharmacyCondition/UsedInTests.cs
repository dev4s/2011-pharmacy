using System.ServiceModel;
using PharmacyCondition.Services;

namespace TestsOfPharmacyCondition
{
	public static class UsedInTests
	{
		public const int ProductId = 7354;
		public const int PharmacyId = 10022;
		public const string Username = "sysdba";
		public const string Password = "masterkey";
		public const string ServerIp = "172.16.0.21";	//NOTE: Change on each Virtual Machine running
		public const int ServerPort = 3050;
		public const string DatabaseName = "apteka.ibb";

		public const string ProductEanCode =			"@5909990772667";	//kod EAN producenta
		public const string ProductDeliveryCode =		"@9046190600003";	//kod dostawy (niesprzedany produkt)
		public const string ProductNotExistingCode =	"@4455667788994";	//nieistniejący kod w bazie
		public const string ProductSelledCode =			"@9041949300005";	//kod dostawy (sprzedany produkt) 
		public const string ProductName =				"POLPRAZOL";

		public const string Address = "net.tcp://localhost:300/DatabaseService";

		public static IProductService CreateClient(string address)
		{
			var tcpBinding = new NetTcpBinding(SecurityMode.None);
			var clientFactory = new ChannelFactory<IProductService>(tcpBinding);
			var clientChannel = clientFactory.CreateChannel(new EndpointAddress(address));
			return clientChannel;
		}

		public static ServiceHost CreateServer(string address)
		{
			return CreateServer(new ProductService(PharmacyId, ServerIp, ServerPort, DatabaseName, Username, Password), address);
		}

		public static ServiceHost CreateServer(ProductService productService, string address)
		{
			var host = new ServiceHost(productService);
			var tcpBinding = new NetTcpBinding(SecurityMode.None);
			host.AddServiceEndpoint(typeof(IProductService), tcpBinding, address);
			return host;
		}
	}
}