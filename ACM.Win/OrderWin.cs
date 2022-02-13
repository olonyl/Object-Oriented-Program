using ACM.DefensiveProgramming.BusinessLogic;
using System;
using System.Windows.Forms;

namespace ACM.DefensiveProgramming.Win
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();

        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            //Populate the customer instance

            var order = new Order();
            //Populate the order instance

            var payment = new Payment();
            //Populate the payment info from the UI

            var allowSplitOrders = false;
            var emailReceipt = true;

            OrderController orderController = new OrderController();

            orderController.PlaceOrder(
                customer,
                order,
                payment,
                allowSplitOrders: allowSplitOrders,
                emailReceipt: emailReceipt);
        }

    }
}
