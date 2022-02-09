using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            return new Customer(customerId)
            {
                EmailAddress = "jsoe87.landeros@gmail.com",
                FirstName = "Olonyl",
                LastName = "Landeros"
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
