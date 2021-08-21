using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class MouseTests
    {
        [TestMethod]
        public void MakeSound_Mouse_ExpectedPiiii()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Black", 0.2, 0, "Home");

            //Act
            string result = mouse.MakeSound();

            //Assert
            Assert.AreEqual("> Piiii!", result);
        }

        [TestMethod]
        public void Eat_Meat4_Expected4()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Black", 0.2, 0, "Home");
            Food food = new Meat(4);

            //Act
            int result = mouse.Eat(food);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Eat_Vegetable5_Expected5()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Black", 0.2, 0, "Home");
            Food food = new Vegetable(5);

            //Act
            int result = mouse.Eat(food);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ToString_Mouse_ExpectedStringMouse()
        {
            //Arrange
            Mouse mouse = new Mouse("Mouse", "Black", 0.2, 0, "Home");

            //Act
            string result = mouse.ToString();

            //Assert
            Assert.AreEqual("> Black[Mouse, 0,2, Home, 0]", result);
        }
    }
}
