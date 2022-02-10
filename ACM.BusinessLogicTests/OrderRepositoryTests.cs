using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BusinessLogicTests
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void RetriveOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();

            OrderDisplay expected = new OrderDisplay
            {
                FirstName = "Olonyl",
                LastName = "Landeros",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan()),
                ShippingAddress = new Address
                {
                    AddressType = 1,
                    StreetLine1 = "Street Line 1",
                    StreetLine2 = "Street Line 2",
                    City = "Managua",
                    State = "Managua",
                    Country = "Nicaragua",
                    PostalCode = "13012"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>
                {
                    new OrderDisplayItem
                    {
                        OrderQuantity=10,
                        ProductName="T-Shirt",
                        PurchasePrice=10.89m
                    },
                    new OrderDisplayItem
                    {
                        OrderQuantity=2,
                        ProductName="Shoes",
                        PurchasePrice=15.83m
                    }
                }
            };

            var actual = orderRepository.RetrieveOrderDisplay(10);

            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < expected.OrderDisplayItemList.Count; i++)
            {
                Assert.AreEqual(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
            }

        }
        [TestMethod]
        public void Retrieve()
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
