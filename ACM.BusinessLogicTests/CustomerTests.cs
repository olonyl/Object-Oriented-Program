using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BusinessLogicTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullName_ProvidedFirstAndLastName_ReturnsValidFullName()
        {
            Customer customer = new Customer
            {
                FirstName = "Olonyl",
                LastName = "Landeros"
            };

            var expected = "Landeros, Olonyl";
            var actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullName_FirstNameEmpty_ReturnsLastName()
        {
            Customer customer = new Customer
            {
                LastName = "Landeros"
            };

            var expected = "Landeros";
            var actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullName_LastNameEmpty_ReturnsFirstName()
        {
            Customer customer = new Customer
            {
                FirstName = "Olonyl"
            };

            var expected = "Olonyl";
            var actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            Customer c1 = new Customer
            {
                FirstName = "Olonyl",
            };
            Customer.InstanceCount += 1;

            Customer c2 = new Customer
            {
                FirstName = "Horacio"
            };
            Customer.InstanceCount += 1;

            Customer c3 = new Customer
            {
                FirstName = "Landeros"
            };
            Customer.InstanceCount += 1;


            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Olonyl",
                LastName = "Landeros"
            };

            Assert.IsTrue(customer.Validate());
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            Customer customer = new Customer
            {
                FirstName = "Olonyl"
            };

            Assert.IsFalse(customer.Validate());
        }
    }
}
