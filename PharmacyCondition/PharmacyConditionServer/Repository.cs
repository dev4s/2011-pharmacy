using PharmacyConditionServer.Properties;

namespace PharmacyConditionServer
{
	public class Repository : PharmacyCondition.Database.Repository
	{
		public Repository()
			: base(Settings.Default.DBFilePath,
				   Settings.Default.DbPharmacyId,
				   Settings.Default.DBUsername,
				   Password.Decrypt(Settings.Default.DBPassword)) { }
	}
}