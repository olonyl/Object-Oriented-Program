using System;

namespace ACM.DefensiveProgramming.BusinessLogic
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            /*
             Send and email receipt
            If the user requested a receipt
            Get the customer data
            Ensure a valid email address was provided
            If not 
            request an email address from the user
             */
        }

        public decimal CalculatePrecentOfGoalStatus(string goalSteps, string actualSteps)
        {

            decimal goalStepCount;
            decimal actualStepsCount = 0;

            if (goalSteps.IsEmpty()) throw new ArgumentException("Goal must be entered", nameof(goalSteps));
            if (goalSteps.IsEmpty()) throw new ArgumentException("Actual steps must be entered", nameof(actualSteps));

            if (!decimal.TryParse(goalSteps, out goalStepCount))
            {
                throw new ArgumentException("Goal must be numeric", nameof(goalSteps));
            }
            if (!decimal.TryParse(actualSteps, out actualStepsCount))
            {
                throw new ArgumentException("Actual steps must be numeric", nameof(actualSteps));
            }
            return CalculatePrecentOfGoalStatus(goalStepCount, actualStepsCount);
        }
        public decimal CalculatePrecentOfGoalStatus(decimal goalStepCount, decimal actualStepsCount)
        {


            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", nameof(goalStepCount));

            return (actualStepsCount / goalStepCount) * 100;
        }
    }
}
