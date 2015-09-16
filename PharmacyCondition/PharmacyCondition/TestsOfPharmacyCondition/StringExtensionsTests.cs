//using NUnit.Framework;
//using PharmacyCondition.Services;

//namespace TestsOfPharmacyCondition
//{
//    [TestFixture]
//    public class StringExtensionsTests
//    {
//        #region TestMethod
//        private static void CheckBarcode(string barcode, string prefix, int length)
//        {
//            //Act
//            var trimmedCode = barcode.TrimBarcode(prefix);

//            //Assert
//            Assert.That(trimmedCode.Length, Is.EqualTo(length));
//            Assert.That(trimmedCode[0], Is.Not.EqualTo(prefix));
//        }
//        #endregion

//        [Test]
//        public void CheckIfEanBarcodeIsUntrimmedWithoutPrefix()
//        {
//            //Arrange
//            var tempCode = UsedInTests.ProductEanCode.Substring(1, UsedInTests.ProductEanCode.Length - 1);

//            //Act + Assert
//            CheckBarcode(tempCode, "", 13);
//        }

//        [Test]
//        public void CheckIfEanBarcodeIsTrimmedWithPrefix()
//        {
//            CheckBarcode(UsedInTests.ProductEanCode, "@", 13);
//        }

//        [Test]
//        public void CheckIfSellCodeIsTrimmedWithoutPrefix()
//        {
//            //Arrange
//            var tempCode = UsedInTests.ProductSelledCode.Substring(1, UsedInTests.ProductSelledCode.Length - 1);

//            //Act + Assert
//            CheckBarcode(tempCode, "", 12);
//        }

//        [Test]
//        public void CheckIfSellCodeIsTrimmedWithPrefix()
//        {
//            CheckBarcode(UsedInTests.ProductSelledCode, "@", 12);
//        }
//    }
//}