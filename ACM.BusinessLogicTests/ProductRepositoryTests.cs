using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BusinessLogicTests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            var productId = 1;
            var expected = new Product(productId)
            {
                CurrentPrice = 10,
                ProductDescription = "T-Shirt",
                ProductName = "T-Shirt"
            };

            var actual = new ProductRepository().Retrieve(productId);

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
    }
}
