//using System.ServiceModel;
//using NUnit.Framework;
//using PharmacyCondition.Database;
//using PharmacyCondition.Services;

//namespace TestsOfPharmacyCondition
//{
//    [TestFixture]
//    public class DatabaseServiceTests
//    {
//        private ServiceHost _host;
//        private IProductService _client;

//        #region Setups and Cleanings
//        [TestFixtureSetUp]
//        public void SetUp()
//        {
//            _host = UsedInTests.CreateServer(UsedInTests.Address);
//            _host.Open();

//            _client = UsedInTests.CreateClient(UsedInTests.Address);
//        }

//        [TestFixtureTearDown]
//        public void TearDown()
//        {
//            _host.Close();
//        }
//        #endregion

//        [Test]
//        public void CheckIfGoodDataIsReceviedFromWcfService()
//        {
//            //Arrange (up)
//            //Act
//            var result = _client.FindData(UsedInTests.ProductEanCode, "@");

//            //Assert
//            Assert.That(result, Is.Not.Null);
//            Assert.That(result.ID, Is.EqualTo(UsedInTests.ProductId));
//            StringAssert.Contains(UsedInTests.ProductName, result.Name);
//            Assert.That(result.BarcodeType, Is.EqualTo(TypeOfBarcode.Ean));
//        }

//        [Test]
//        public void CheckIfNoDataIsReceviedFromWcfService()
//        {
//            //Arrange (up)
//            //Act
//            var result = _client.FindData("dfasdfasdf", "@");

//            //Assert
//            Assert.That(result, Is.Not.Null);
//            Assert.That(result.BarcodeType, Is.EqualTo(TypeOfBarcode.NotExisting));
//        }

//        //TODO: Tests for services
//        //[Test]
//        //public void CheckIfGoodQuantityIsReturnedWithGoodId()
//        //{
//        //    //Arrange (up)
//        //    //Act
//        //    var result = _client.GetEanQuantity(UsedInTests.ProductId);

//        //    //Assert
//        //    Assert.That(result, Is.EqualTo(26));
//        //}

//        //[Test]
//        //public void CheckIfNoQuantityIsReturnedWithBadId()
//        //{
//        //    //Arrange (up)
//        //    //Act
//        //    var result = _client.GetEanQuantity(-1);

//        //    //Assert
//        //    Assert.That(result, Is.EqualTo(-1));
//        //}
//    }
//}