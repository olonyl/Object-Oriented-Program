﻿namespace ACM.DefensiveProgramming.BusinessLogic
{
    public class InventoryRespository
    {
        public void OrderItems(Order order, bool allowSplitOrders)
        {
            /*
             Order the items from inventory
            For each item ordered
            Locate the item in inventory
            If no longer available, notify the user
            If any items are back ordered and 
            the customer does not want split orders
            notify the user
            If the item is available.
            Open a connection
            Set stored procedure parameters with the inventory data
            Call the save stored procedure
             */
        }
    }
}
