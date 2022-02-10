using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            return new Address(addressId)
            {
                StreetLine1 = "Barrio Tierra Prometida",
                StreetLine2 = "Bloquera San Antonio",
                City = "Managua",
                Country = "Managua",
                PostalCode = "13012",
            };
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "First Line of this address",
                StreetLine2 = "Second Line of this address",
                City = "Managua",
                State = "Managua",
                Country = "Nicaragua",
                PostalCode = "13012"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "First Line of this address",
                StreetLine2 = "Second Line of this address",
                City = "Masaya",
                State = "Masaya",
                Country = "Nicaragua",
                PostalCode = "14331"
            };
            addressList.Add(address);

            return addressList;

        }

        public bool Save()
        {
            return true;
        }
    }
}
