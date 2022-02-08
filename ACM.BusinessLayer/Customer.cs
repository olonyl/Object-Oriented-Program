using System;

namespace ACM.BusinessLayer
{
    public class Customer
    {
        public static int InstanceCount { get; set; }
        private string _lastName;
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

    }
}
