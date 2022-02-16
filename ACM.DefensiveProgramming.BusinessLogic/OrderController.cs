using ACM.DefensiveProgramming.Core.Common;
using System;
using System.Diagnostics;
using System.Linq;

namespace ACM.DefensiveProgramming.BusinessLogic
{
    public class OrderController
    {
        private CustomerRepository _customerRepository;
        private OrderRepository _orderRepository;
        private InventoryRespository _inventoryRepository;
        private EmailLibrary _emailLibrary;

        public OrderController()
        {
            _customerRepository = new CustomerRepository();
            _orderRepository = new OrderRepository();
            _inventoryRepository = new InventoryRespository();
            _emailLibrary = new EmailLibrary();
        }

        public OperationResult PlaceOrder(Customer customer,
            Order order,
            Payment payment,
            bool allowSplitOrders,
            bool emailReceipt)
        {

            Debug.Assert(_customerRepository != null, "Missing customer repository instance");
            Debug.Assert(_orderRepository != null, "Missing order repository instance");
            Debug.Assert(_inventoryRepository != null, "Missing inventory repository instance");
            Debug.Assert(_emailLibrary != null, "Missing email library instance");

            if (customer == null) throw new ArgumentNullException("Customer instance is null");
            if (order == null) throw new ArgumentNullException("Order instance is null");
            if (payment == null) throw new ArgumentNullException("Payment instance is null");

            var operationResult = new OperationResult();

            _customerRepository.Add(customer);
            _orderRepository.Add(order);
            _inventoryRepository.OrderItems(order, allowSplitOrders);
            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmail();
                if (result.Success)
                {
                    _emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
                }
                else
                {
                    // log the message
                    if (result.MessageList.Any())
                    {
                        operationResult.AddMessage(result.MessageList[0]);
                    }
                }
            }
            return operationResult;
        }
    }
}
