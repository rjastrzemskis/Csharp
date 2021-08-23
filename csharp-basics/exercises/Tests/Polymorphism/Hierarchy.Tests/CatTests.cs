using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void MakeSound_Cat_ExpectedMeowwww()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, 0, "Home", "Persian");

            //Act
            string result = cat.MakeSound();

            //Assert
            Assert.AreEqual("> Meowwww!", result);
        }

        [TestMethod]
        public void Eat_Meat4_Expected4()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, 0, "Home", "Persian");
            Food food = new Meat(4);

            //Act
            int result = cat.Eat(food);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Eat_Vegetable5_Expected5()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, 0, "Home", "Persian");
            Food food = new Vegetable(5);

            //Act
            int result = cat.Eat(food);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ToString_Cat_ExpectedStringCat()
        {
            //Arrange
            Cat cat = new Cat("Cat", "Gray", 1.1, 0, "Home", "Persian");

            //Act
            string result = cat.ToString();

            //Assert
            Assert.AreEqual("> Gray[Cat, Persian, 1,1, Home, 0]", result);
        }
    }
}
