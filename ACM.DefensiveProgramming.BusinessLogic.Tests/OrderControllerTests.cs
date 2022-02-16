using ACM.DefensiveProgramming.BusinessLogic;
using ACM.DefensiveProgramming.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.DefensiveProgramming.BusinessLogicTests
{
    [TestClass]
    public class OrderControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTest()
        {
            //-- Arrange
            var orderController = new OrderController();
            var customer = new Customer
            {
                EmailAddress = "jose87.landeros@gmail.com"
            };
            Order order = null;
            var payment = new Payment { PaymentType = 1 };
            //-- Act
            OperationResult result = orderController.PlaceOrder(customer,
                order,
                payment,
                allowSplitOrders: true,
                emailReceipt: true);

            //-- Assert
        }

        [TestMethod]
        public void PlaceOrderTestInvalidEmail()
        {
            //-- Arrange
            var orderController = new OrderController();
            var customer = new Customer
            {
                EmailAddress = ""
            };
            var order = new Order();
            var payment = new Payment { PaymentType = 1 };
            //-- Act
            OperationResult result = orderController.PlaceOrder(customer,
                order,
                payment,
                allowSplitOrders: true,
                emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, result.Success);
            Assert.AreEqual(1, result.MessageList.Count);
            Assert.AreEqual("Email address is null", result.MessageList[0]);
        }
    }
}