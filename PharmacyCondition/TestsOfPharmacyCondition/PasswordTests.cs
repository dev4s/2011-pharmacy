using NUnit.Framework;
using PharmacyConditionServer;

namespace TestsOfPharmacyCondition
{
	[TestFixture]
	public class PasswordTests
	{
		[Test]
		public static void TestPasswordDecodeAndEncode()
		{
			//Arrange
			const string password = "masterkey"; //Encoded version: bWFzdGVya2V5

			//Act
			var passwordEncoded = Password.Encrypt(password);
			var passwordDecoded = Password.Decrypt(passwordEncoded);

			//Assert
			Assert.That(passwordEncoded, Is.EqualTo("bWFzdGVya2V5"));
			Assert.That(passwordDecoded, Is.EqualTo("masterkey"));
		}
	}
}
