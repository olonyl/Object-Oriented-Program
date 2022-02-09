using System;

namespace ACM.BusinessLayer
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public bool Validate()
        {
            return OrderDate != null;
        }

    }
}
