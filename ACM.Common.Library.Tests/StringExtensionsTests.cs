using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.Common.Library.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsEmpty_ProvideNullEmptyWhiteSpace_ReturnsTrue()
        {
            Assert.IsTrue(StringExtensions.IsEmpty(" "));
            Assert.IsTrue(StringExtensions.IsEmpty(string.Empty));
            Assert.IsTrue(StringExtensions.IsEmpty(null));
        }
        [TestMethod]
        public void IsEmpty_ProvideValidString_ReturnsFalse()
        {
            Assert.IsFalse(StringExtensions.IsEmpty("This is something"));
        }
    }
}
