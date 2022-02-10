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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay
            {
                FirstName = "Olonyl",
                LastName = "Landeros",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan()),
                ShippingAddress = new Address
                {
                    AddressType = 1,
                    StreetLine1 = "Street Line 1",
                    StreetLine2 = "Street Line 2",
                    City = "Managua",
                    State = "Managua",
                    Country = "Nicaragua",
                    PostalCode = "13012"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>
                {
                    new OrderDisplayItem
                    {
                        OrderQuantity=10,
                        ProductName="T-Shirt",
                        PurchasePrice=10.89m
                    },
                    new OrderDisplayItem
                    {
                        OrderQuantity=2,
                        ProductName="Shoes",
                        PurchasePrice=15.83m
                    }
                }
            };
            return orderDisplay;

        }

        public bool Save()
        {
            return true;
        }
    }
}