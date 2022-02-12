using ACM.Common.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class Order : EntityBase, ILoggable
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

        public string Log()
        {
            var logString = $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState.GetDescription()}";
            return logString;
        }
    }
}
