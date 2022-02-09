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
    }
}
