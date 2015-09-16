//using System.ServiceModel;
//using NUnit.Framework;
//using PharmacyCondition.Services;

//namespace TestsOfPharmacyCondition
//{
//    [TestFixture]
//    public class QueueTests
//    {
//        private ServiceHost _host;
//        private ProductService _productService;

//        #region Setups and Cleanings
//        [SetUp]
//        public void SetUp()
//        {
//            _productService = new ProductService(UsedInTests.PharmacyId, 
//                                                 UsedInTests.ServerIp, 
//                                                 UsedInTests.ServerPort,
//                                                 UsedInTests.DatabaseName, 
//                                                 UsedInTests.Username, 
//                                                 UsedInTests.Password);
//            _host = UsedInTests.CreateServer(_productService, UsedInTests.Address);
//            _host.Open();
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            _productService = null;
//            _host.Close();
//        }
//        #endregion

//        [Test]
//        public void CheckIfQueueIsWorkingGoodForTwoClients()
//        {
//            //Arrange
//            var client1 = UsedInTests.CreateClient(UsedInTests.Address);
//            var client2 = UsedInTests.CreateClient(UsedInTests.Address);
//            client1.FindData(UsedInTests.ProductEanCode, "@");
//            client2.FindData(UsedInTests.ProductEanCode, "@");
//            client1.FindData(UsedInTests.ProductNotExistingCode, "@");
//            client2.FindData(UsedInTests.ProductDeliveryCode, "@");
//            client1.FindData(UsedInTests.ProductEanCode, "@");

//            //Act
//            //var howManyBefore = _productService.HowManyStackItemsInQueue();
//            //var prod1 = _productService.GetThreadStackFromQueue();
//            //var prod2 = _productService.GetThreadStackFromQueue();
//            //var prod3 = _productService.GetThreadStackFromQueue();
//            //var prod4 = _productService.GetThreadStackFromQueue();
//            //var prod5 = _productService.GetThreadStackFromQueue();
//            //var prod6 = _productService.GetThreadStackFromQueue();
//            //var howManyAfter = _productService.HowManyStackItemsInQueue();

//            //Assert
//            //Assert.That(howManyBefore, Is.EqualTo(5));
//            //Assert.That(prod1.BarcodeType, Is.EqualTo(TypeOfBarcode.Ean));
//            //Assert.That(prod2.BarcodeType, Is.EqualTo(TypeOfBarcode.Ean));
//            //Assert.That(prod3.BarcodeType, Is.EqualTo(TypeOfBarcode.NotExisting));
//            //Assert.That(prod4.BarcodeType, Is.EqualTo(TypeOfBarcode.Delivery));
//            //Assert.That(prod5.BarcodeType, Is.EqualTo(TypeOfBarcode.Ean));
//            //Assert.That(howManyAfter, Is.EqualTo(0));
//            //Assert.That(prod6, Is.Null);
//        }
//    }
//}