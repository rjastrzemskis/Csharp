using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class ZebraTests
    {
        [TestMethod]
        public void MakeSound_Zebra_ExpectedKsaaa()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "White", 2.3, 0, "Brazil");

            //Act
            string result = zebra.MakeSound();

            //Assert
            Assert.AreEqual("> Ksaaa!", result);
        }

        [TestMethod]
        public void Eat_Meat4_Expected4()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "White", 2.3, 0, "Brazil");
            Food food = new Vegetable(4);

            //Act
            int result = zebra.Eat(food);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Eat_Vegetable5_ArgumentException()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "White", 2.3, 0, "Brazil");
            Food food = new Meat(5);

            //Act
            Action act = () => zebra.Eat(food);

            //Assert
            Assert.AreEqual("> Whites are not eating that type of food!",
                Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void ToString_Cat_ExpectedStringZebra()
        {
            //Arrange
            Zebra zebra = new Zebra("Zebra", "White", 2.3, 0, "Brazil");

            //Act
            string result = zebra.ToString();

            //Assert
            Assert.AreEqual("> White[Zebra, 2,3, Brazil, 0]", result);
        }
    }
}
