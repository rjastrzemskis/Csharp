using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class MeatTests
    {
        [TestMethod]
        public void ToString_Meat_ExpectedMeat()
        {
            //Arrange
            Meat meat = new Meat(4);

            //Act
            string result = meat.ToString();

            //Assert
            Assert.AreEqual("Meat", result);
        }
    }
}
