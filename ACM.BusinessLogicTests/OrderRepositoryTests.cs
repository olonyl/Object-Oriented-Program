using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BusinessLogicTests
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var orderId = 1;
            var orderRespository = new OrderRepository();
            var expected = new Order(orderId)
            {
                OrderDate = new DateTimeOffset(2022, 2, 8, 22, 12, 10, TimeSpan.Zero)
            };

            var actual = orderRespository.Retrieve(orderId);

            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
