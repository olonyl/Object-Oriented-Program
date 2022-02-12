using ACM.BusinessLayer;
using ACM.Common.Library.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.Common.Library.Tests
{

    [TestClass]
    public class LoggingServiceTests
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "jose87.landeros@gmail.com",
                FirstName = "Olonyl",
                LastName = "Landeros",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            var order = new Order(2)
            {
                OrderDate = new DateTimeOffset(2022, 01, 20, 10, 20, 00, new TimeSpan())
            };
            changedItems.Add(order);

            LoggingService.WriteToFile(changedItems);

        }
    }

}