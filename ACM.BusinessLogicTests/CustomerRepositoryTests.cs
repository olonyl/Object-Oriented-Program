using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BusinessLogicTests
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            var customerId = 1;
            var customerRepository = new CustomerRepository();
            var expected = new Customer(customerId)
            {
                EmailAddress = "jsoe87.landeros@gmail.com",
                FirstName = "Olonyl",
                LastName = "Landeros"
            };

            var actual = customerRepository.Retrieve(customerId);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "jsoe87.landeros@gmail.com",
                FirstName = "Olonyl",
                LastName = "Landeros",
                AddressList = {
                    new Address(1)
                    {
                        AddressType = 1,
                        StreetLine1 = "First Line of this address",
                        StreetLine2 = "Second Line of this address",
                        City = "Managua",
                        State = "Managua",
                        Country = "Nicaragua",
                        PostalCode = "13012"
                    },
                    new Address(2)
                    {
                        AddressType = 2,
                        StreetLine1 = "First Line of this address",
                        StreetLine2 = "Second Line of this address",
                        City = "Masaya",
                        State = "Masaya",
                        Country = "Nicaragua",
                        PostalCode = "14331"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < expected.AddressList.Count; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
