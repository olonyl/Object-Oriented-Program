using System;
using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class Order : EntityBase
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }

        public override bool Validate()
        {
            return OrderDate != null;
        }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }

    }
}
