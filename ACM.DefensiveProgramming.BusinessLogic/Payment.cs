
using System;
using System.ComponentModel;

namespace ACM.DefensiveProgramming.BusinessLogic
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {

        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            /*
             Process the payment
            If there is a payment problem, notify the user
            Open a connection
            Set stored procedure parameters with the payment data
            Call the save stored procedure
             */
            PaymentType paymentTypeOption;
            if (!Enum.TryParse(PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment Type", (int)PaymentType, typeof(PaymentType));
            }
            switch (paymentTypeOption)
            {
                case BusinessLogic.PaymentType.CreditCard:
                    break;
                case BusinessLogic.PaymentType.PayPal:
                    break;
                default:
                    throw new ArgumentException();
            }

        }
    }
}
