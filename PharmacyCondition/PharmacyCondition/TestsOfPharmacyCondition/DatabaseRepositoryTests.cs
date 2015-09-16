//using NUnit.Framework;
//using PharmacyCondition.Database;

//namespace TestsOfPharmacyCondition
//{
//    [TestFixture]
//    public class DatabaseRepositoryTests
//    {
//        private Repository _repository;

//        //POLPRAZOL
//        private const string ProductEanCode =			"5909990772667";	//kod EAN producenta
//        private const string ProductDeliveryCode =		"904619060000";		//kod dostawy (niesprzedany produkt)
//        private const string ProductNotExistingCode =	"4455667788994";	//nieistniejący kod w bazie
//        private const string ProductSelledCode =		"904194930000";		//kod dostawy (sprzedany produkt) 
//        private const string ProductName =				"POLPRAZOL";

//        #region Setups and teardowns for each test in fixture
//        [SetUp]
//        public void SetUp()
//        {
//            _repository = new Repository(UsedInTests.ServerIp,
//                                         UsedInTests.ServerPort,
//                                         UsedInTests.DatabaseName,
//                                         UsedInTests.Username,
//                                         UsedInTests.Password) {PharmacyId = UsedInTests.PharmacyId};
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            _repository = null;
//        }
//        #endregion

//        [Test]
//        public void CheckConnectionWithGoodDataPassed()
//        {
//            //Arrange
//            //Act
//            var result = Repository.IsThisAProperConnection(UsedInTests.ServerIp,
//                                                            UsedInTests.ServerPort,
//                                                            UsedInTests.DatabaseName,
//                                                            UsedInTests.Username,
//                                                            UsedInTests.Password);

//            //Assert
//            Assert.That(result, Is.True);
//        }

//        [Test]
//        public void CheckConnectionWithBadDataPassed()
//        {
//            //Arrange
//            //Act
//            var result = Repository.IsThisAProperConnection("", 0, "", "", "");

//            //Assert
//            Assert.That(result, Is.False);
//        } 

//        [Test]
//        public void GetProductIdUsingDeliveryCode()
//        {
//            //Arrange (up)
//            //Act
//            var result = _repository.FindProduct(ProductDeliveryCode);

//            //Assert
//            Assert.That(result, Is.Not.Null);
//            Assert.That(result.ID, Is.EqualTo(UsedInTests.ProductId));
//            Assert.That(result.BarcodeType, Is.EqualTo(TypeOfBarcode.Delivery));
//            StringAssert.Contains(ProductName, result.Name);
//            Assert.That(result.Barcode, Is.EqualTo(ProductDeliveryCode));
//        }

//        [Test]
//        public void GetProductIdUsingEanCode()
//        {
//            //Arrange (up)
//            //Act
//            var result = _repository.FindProduct(ProductEanCode);

//            //Assert
//            Assert.That(result, Is.Not.Null);
//            Assert.That(result.ID, Is.EqualTo(UsedInTests.ProductId));
//            Assert.That(result.BarcodeType, Is.EqualTo(TypeOfBarcode.Ean));
//            StringAssert.Contains(ProductName, result.Name);
//            Assert.That(result.Barcode, Is.EqualTo(ProductEanCode));
//        }

//        [Test]
//        public void GetProductIdUsingNotExistingCode()
//        {
//            //Arrange (up)
//            //Act
//            var result = _repository.FindProduct(ProductNotExistingCode);

//            //Assert
//            Assert.That(result, Is.Not.Null);
//            Assert.That(result.ID, Is.EqualTo(0));
//            Assert.That(result.BarcodeType, Is.EqualTo(TypeOfBarcode.NotExisting));
//            Assert.That(result.Name, Is.Null);
//            Assert.That(result.Barcode, Is.EqualTo(ProductNotExistingCode));
//        }

//        [Test]
//        public void GetProductIdWithSelledBarCode()
//        {
//            //Arrange (up)
//            //Act
//            var result = _repository.FindProduct(ProductSelledCode);

//            //Assert
//            Assert.That(result, Is.Not.Null);
//            Assert.That(result.ID, Is.EqualTo(UsedInTests.ProductId));
//            Assert.That(result.BarcodeType, Is.EqualTo(TypeOfBarcode.Selled));
//            StringAssert.Contains(ProductName, result.Name);
//            Assert.That(result.Barcode, Is.EqualTo(ProductSelledCode));
//        }

//        [Test]
//        public void GetProductQuantity()
//        {
//            //Arrange (up)
//            //Act
//            var result = _repository.GetEanQuantity(UsedInTests.ProductId);

//            //Assert
//            Assert.That(result, Is.EqualTo(26));
//        }

//        [Test]
//        public void GetProductQuantityWithBadProductId()
//        {
//            //Arrange (up)
//            //Act
//            var result = _repository.GetEanQuantity(0);

//            //Assert
//            Assert.That(result, Is.EqualTo(-1));
//        }
//    }
//}