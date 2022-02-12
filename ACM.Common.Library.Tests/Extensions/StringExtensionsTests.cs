using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.Common.Library.Tests.Extension
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

        [TestMethod]
        public void InsertSpaces_WhenValueIsEmptyOrNull_ReturnsSameVelue()
        {
            Assert.AreEqual(null, StringExtensions.InsertSpaces(null));
            Assert.AreEqual(" ", StringExtensions.InsertSpaces(" "));
            Assert.AreEqual("", StringExtensions.InsertSpaces(""));
        }

        [TestMethod]
        [DataRow("Hola Mundo", "HolaMundo")]
        [DataRow("holamundo", "holamundo")]
        [DataRow("hola Mundo", "holaMundo")]
        [DataRow("Hola Mundo", " HolaMundo ")]
        public void InsertSpaces_WhenValueIsNotEmpry_ReturnsSameStringWithAnSpaceBeforeEachUppercaseLetter(
            string expected,
            string value
            )
        {
            Assert.AreEqual(expected, StringExtensions.InsertSpaces(value));
        }
    }
}
