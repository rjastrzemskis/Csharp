using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Test
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void StockInformation_NameLogitechMousePrice70Amount14_ExpecteStringStockInfo()
        {
            // Arrange
            Product first = new Product("Logitech mouse", (decimal)70.00, 14);

            // Act
            string result = first.StockInformation();

            // Assert
            Assert.AreEqual("Logitech mouse, price 70$, amount 14", result);
        }

        [TestMethod]
        public void IncreaseAmount_NameLogitechMousePrice70Amount14_ExpectedAmount24()
        {
            // Arrange
            Product first = new Product("Logitech mouse", (decimal)70.00, 14);

            // Act
            int result = first.IncreaseAmount(10);

            // Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void IncreaseAmount_NameLogitechMousePrice70Amount14_ExpectedAmount4()
        {
            // Arrange
            Product first = new Product("Logitech mouse", (decimal)70.00, 14);

            // Act
            int result = first.DecreaseAmount(10);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void IncreaseAmount_NameLogitechMousePrice70Amount14_ExpectedPrice100()
        {
            // Arrange
            Product first = new Product("Logitech mouse", (decimal)70.00, 14);

            // Act
            decimal result = first.UpdatePrice(100);

            // Assert
            Assert.AreEqual(100, result);
        }
    }
}
