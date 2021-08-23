using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class VegetableTests
    {
        [TestMethod]
        public void ToString_Vegetable_ExpectedVegetable()
        {
            //Arrange
            Vegetable vegetable = new Vegetable(4);

            //Act
            string result = vegetable.ToString();

            //Assert
            Assert.AreEqual("Vegetable", result);
        }
    }
}
