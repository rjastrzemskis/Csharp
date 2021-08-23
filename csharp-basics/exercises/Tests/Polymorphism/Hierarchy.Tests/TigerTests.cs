using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class TigerTests
    {
        [TestMethod]
        public void MakeSound_Tiger_ExpectedROAAR()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Brown", 3.3, 0, "China");

            //Act
            string result = tiger.MakeSound();

            //Assert
            Assert.AreEqual("> ROAAR!", result);
        }

        [TestMethod]
        public void Eat_Meat4_Expected4()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Brown", 3.3, 0, "China");
            Food food = new Meat(4);

            //Act
            int result = tiger.Eat(food);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Eat_Vegetable5_ArgumentException()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Brown", 3.3, 0, "China");
            Food food = new Vegetable(5);

            //Act
            Action act = () => tiger.Eat(food);

            //Assert
            Assert.AreEqual("> Browns are not eating that type of food!",
                Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void ToString_Cat_ExpectedStringTiger()
        {
            //Arrange
            Tiger tiger = new Tiger("Tiger", "Brown", 3.3, 0, "China");

            //Act
            string result = tiger.ToString();

            //Assert
            Assert.AreEqual("> Brown[Tiger, 3,3, China, 0]", result);
        }
    }
}
