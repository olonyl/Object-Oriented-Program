using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.Common.Library.Tests.Extension
{
    [TestClass]
    public class ExceptionExtensionsTests
    {
        [TestMethod]
        [DataRow("This is my error", "This is my error")]
        [DataRow("", "")]
        public void GetFullErrorMessage_OnSingleError_ReturnsOnlyThatErrorMessage(string errorMessage, string expected)
        {
            var exception = new Exception(errorMessage);
            var actual = exception.GetFullErrorMessage();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFullErrorMessage_OnMultipleErrorsWithinInnerErrors_ReturnsAllErrorMessageIncludingInnerMessage()
        {
            var exception = new Exception("This is my error");
            exception = new Exception("This is my other error", exception);

            var expected = $"This is my other error{Environment.NewLine}This is my error";
            var actual = exception.GetFullErrorMessage();

            Assert.AreEqual(expected, actual);
        }
    }

}