using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.DefensiveProgramming.BusinessLogic.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        [DynamicData(nameof(CustomerTestStringData.GetValidData), typeof(CustomerTestStringData), DynamicDataSourceType.Method)]
        public void CalculatePercentOfGoalStatus_WithValidValues_ReturnsValidResult(
            string goalSteps,
            string actualSteps,
            decimal expected
            )
        {
            var customer = new Customer();

            var actual = customer.CalculatePercentOfGoalStatus(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DynamicData(nameof(CustomerTestStringData.GetInvalidData), typeof(CustomerTestStringData), DynamicDataSourceType.Method)]
        public void CalculatePercentOfGoalStatus_WhenTestGoalIsNull_ReturnsException(
            string goalSteps,
            string actualSteps
            )
        {
            var customer = new Customer();

            customer.CalculatePercentOfGoalStatus(goalSteps, actualSteps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("one", "2000", "Goal must be numeric")]
        public void CalculatePercentOfGoalStatus_WhenGoalIsNotAVaildNumericValue_ReturnsSpecificMessage(
            string goalSteps,
            string actualSteps,
            string expectedResult
            )
        {
            var customer = new Customer();
            try
            {
                customer.CalculatePercentOfGoalStatus(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expectedResult, ex.Message);
                throw;

            }

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("1", "two", "Actual steps must be numeric")]
        public void CalculatePercentOfGoalStatus_WhenActualIsNotAVaildNumericValue_ReturnsSpecificMessage(
           string goalSteps,
           string actualSteps,
           string expectedResult
           )
        {
            var customer = new Customer();
            try
            {
                customer.CalculatePercentOfGoalStatus(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expectedResult, ex.Message);
                throw;

            }

        }

        class CustomerTestStringData
        {
            public static IEnumerable<object[]> GetValidData()
            {
                yield return new object[] { "5000", "2000", 40m };
                yield return new object[] { "5000", "5000", 100m };
                yield return new object[] { "5000", "0", 0m };
            }
            public static IEnumerable<object[]> GetInvalidData()
            {
                yield return new object[] { null, "2000" };
                yield return new object[] { "2000", null };
            }
        }
        class CustomerTestDecimal
        {
            public static IEnumerable<object[]> GetValidData()
            {
                yield return new object[] { 5000, 2000, 40m };
                yield return new object[] { 5000, 5000, 100m };
                yield return new object[] { 5000, 0, 0m };
            }
        }
    }


}
