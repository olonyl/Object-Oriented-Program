using System;
using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class Customer
    {
        private string _lastName;

        public Customer()
            : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                if (!FirstName.IsEmpty() && !LastName.IsEmpty())
                    return $"{LastName}, {FirstName}";
                if (!FirstName.IsEmpty())
                    return FirstName;
                if (!LastName.IsEmpty())
                    return LastName;
                return string.Empty;
            }
        }

        public bool Validate()
        {
            return !FirstName.IsEmpty() && !LastName.IsEmpty();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
