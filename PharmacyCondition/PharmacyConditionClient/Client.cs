using System.ServiceModel;
using PharmacyCondition.Services;
using PharmacyConditionClient.Properties;

namespace PharmacyConditionClient
{
	public class Client
	{
		private ChannelFactory<IProductService> _channelFactory;
		public IProductService Channel { get; private set; }

		public void Open()
		{
			var tcpBinding = new NetTcpBinding(SecurityMode.None);
			_channelFactory = new ChannelFactory<IProductService>(tcpBinding);
			Channel = _channelFactory.CreateChannel(new EndpointAddress(string.Format("net.tcp://{0}:{1}/PharmacyService", 
																					   Settings.Default.ServerIp, 
																					   Settings.Default.ServerPort)));
		}

		public void Close()
		{
			_channelFactory.Close();
		}
	}
}