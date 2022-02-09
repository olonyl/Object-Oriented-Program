using System;
using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            return new Order(orderId)
            {
                OrderDate = new DateTimeOffset(2022, 2, 8, 22, 12, 10, TimeSpan.Zero)
            };
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}