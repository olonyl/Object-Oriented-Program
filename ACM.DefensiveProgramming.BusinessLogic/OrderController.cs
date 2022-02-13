using ACM.DefensiveProgramming.Core.Common;

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

        public void PlaceOrder(Customer customer,
            Order order, Payment payment,
            bool allowSplitOrders,
            bool emailReceipt)
        {
            _customerRepository.Add(customer);

            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            _inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment(payment);

            if (emailReceipt)
            {
                customer.ValidateEmail();
                _customerRepository.Update();

                _emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }
        }
    }
}
