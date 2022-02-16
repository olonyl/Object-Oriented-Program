using ACM.DefensiveProgramming.BusinessLogic;
using System;
using System.Windows.Forms;

namespace ACM.DefensiveProgramming.Win
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            try
            {
                var result = customer.CalculatePercentOfGoalStatus(
                             txtGoalSteps.Text,
                             txtActualSteps.Text);
                lblResult.Text = $"You reached {result}% of your goal!";
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.GetFullErrorMessage());
                lblResult.Text = string.Empty;
            }

        }
    }
}
