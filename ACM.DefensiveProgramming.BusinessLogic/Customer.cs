namespace ACM.DefensiveProgramming.BusinessLogic
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            /*
             Send and email receipt
            If the user requested a receipt
            Get the customer data
            Ensure a valid email address was provided
            If not 
            request an email address from the user
             */
        }
    }
}
