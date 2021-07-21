using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsItALeapYear.Services;

namespace IsItALeapYear.Tests
{
    [TestClass]
    public class IsItALeapYearTests
    {
        [TestMethod]
        public void Year_2001_Is_not_a_leap_year()
        {
            // Arrange
            var p = new IsItALeapYearService();
            var expected = false;
            // Act
            var actual = p.IsItALeapYear(2001);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_1996_Is_a_leap_year()
        {
            var isItALeapYearService = new IsItALeapYearService();
            var expectedValue = true;
            var actualValue = isItALeapYearService.IsItALeapYear(1996);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Year_1900_is_not_a_leap_year()
        {
            var isItALeapYearService = new IsItALeapYearService();
            var expectedValue = false;
            var actualValue = isItALeapYearService.IsItALeapYear(1900);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Year_2000_is_a_leap_year()
        {
            var isItALeapYearService = new IsItALeapYearService();
            var expectedValue = true;
            var actualValue = isItALeapYearService.IsItALeapYear(2000);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
