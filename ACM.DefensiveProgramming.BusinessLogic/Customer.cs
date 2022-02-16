using ACM.DefensiveProgramming.Core.Common;
using System;

namespace ACM.DefensiveProgramming.BusinessLogic
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            /*
             Send and email receipt
            If the user requested a receipt
            Get the customer data
            Ensure a valid email address was provided
            If not 
            request an email address from the user
             */

            var result = new OperationResult();

            if (EmailAddress.IsEmpty())
            {
                result.Success = false;
                result.MessageList.Add("Email address is null");
            }
            var isvalidFormat = true;
            //Code here that validates the format of the email
            //using Regular Expressions
            if (result.Success)
            {
                if (!isvalidFormat)
                {
                    result.Success = false;
                    result.MessageList.Add("Email address is not in a correct format");
                }
            }
            var isRealDomain = true;
            //Code here that confirms whether domain exists. 
            if (result.Success)
            {
                if (!isRealDomain)
                {
                    result.Success = false;
                    result.MessageList.Add("Email address does not include a valid domain");
                }
            }
            return result;
        }

        public decimal CalculatePercentOfGoalStatus(string goalSteps, string actualSteps)
        {

            if (goalSteps.IsEmpty()) throw new ArgumentException("Goal must be entered", nameof(goalSteps));
            if (actualSteps.IsEmpty()) throw new ArgumentException("Actual steps must be entered", nameof(actualSteps));

            decimal goalStepCount;
            if (!decimal.TryParse(goalSteps, out goalStepCount))
            {
                throw new ArgumentException("Goal must be numeric");
            }

            decimal actualStepsCount = 0;
            if (!decimal.TryParse(actualSteps, out actualStepsCount))
            {
                throw new ArgumentException("Actual steps must be numeric");
            }
            return CalculatePercentOfGoalStatus(goalStepCount, actualStepsCount);
        }
        public decimal CalculatePercentOfGoalStatus(decimal goalStepCount, decimal actualStepsCount)
        {


            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", nameof(goalStepCount));

            return Math.Round((actualStepsCount / goalStepCount) * 100, 2);
        }
    }
}
