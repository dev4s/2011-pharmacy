using System.ServiceModel;
using PharmacyCondition.Services;
using PharmacyConditionServer.Properties;

namespace PharmacyConditionServer
{
	public class Host
	{
		private ServiceHost _serviceHost;
		public ProductService ProductService { get; private set; }

		public void Open()
		{
			ProductService = new ProductService(Settings.Default.DBPharmacyId, 
												Settings.Default.DBServerIp, 
												Settings.Default.DBServerPort,
												Settings.Default.DBName, 
												Settings.Default.DBUsername, 
												Password.Decrypt(Settings.Default.DBPassword));

			_serviceHost = new ServiceHost(ProductService);
			var tcpBinding = new NetTcpBinding(SecurityMode.None);
			_serviceHost.AddServiceEndpoint(typeof(IProductService), tcpBinding, string.Format("net.tcp://{0}:{1}/PharmacyService", 
																								Settings.Default.ServerIp, 
																								Settings.Default.ServerPort));
			_serviceHost.Open();
		}
		
		public void Close()
		{
			_serviceHost.Close();
		}
	}
}