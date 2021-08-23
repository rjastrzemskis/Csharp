using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Test
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void DisplayDate_Day19Month08Year20221_ExpectedStringDisplayDate()
        {
            // Arrange
            Date dayOff = new Date(19, 08, 2021);

            // Act
            string result = dayOff.DisplayDate();

            // Assert
            Assert.AreEqual("Day off in 19/8/2021", result);
        }

        [TestMethod]
        public void DisplayDate_Day19Month08Year2021_ExpectedDay21()
        {
            // Arrange
            Date dayOff = new Date(19, 08, 2021);

            // Act
            int result = dayOff.setDay(21);

            // Assert
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void DisplayDate_Day19Month09Year2021_ExpectedMonth09()
        {
            // Arrange
            Date dayOff = new Date(19, 08, 2021);

            // Act
            int result = dayOff.setMonth(09);

            // Assert
            Assert.AreEqual(09, result);
        }

        [TestMethod]
        public void DisplayDate_Day19Month08Year2022_ExpectedYear2022()
        {
            // Arrange
            Date dayOff = new Date(19, 08, 2021);

            // Act
            int result = dayOff.setYear(2022);

            // Assert
            Assert.AreEqual(2022, result);
        }
    }
}
