using System.Collections.Generic;
using System.Linq;

namespace ACM.BusinessLayer
{
    public class CustomerRepository
    {
        private AddressRepository _addressRepository;

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            var addresses = _addressRepository.RetrieveByCustomerId(customerId).ToList();
            return new Customer(customerId)
            {
                EmailAddress = "jsoe87.landeros@gmail.com",
                FirstName = "Olonyl",
                LastName = "Landeros",
                AddressList = addresses
            };
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
