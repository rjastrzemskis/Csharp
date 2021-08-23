using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateArea.Test
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void AreaOfCircle_Radius6_Expected113_1()
        {
            // Arrange
            int radius = 6;
            double expected = 113.1;

            //Act
            double result = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaOfCircle_RadiusNegative_ArgumentException()
        {
            // Arrange
            int radius = -6;

            //Act
            Action act = () => Geometry.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual("You entered negative number!", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void AreaOfRectangle_Length7Width5_Expected35()
        {
            //Arrange
            int length = 7;
            int width = 5;

            //Act
            double result = Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void AreaOfRectangle_LengthWidthNegative_ArgumentException()
        {
            //Arrange
            int length = -7;
            int width = -5;

            //Act
            Action act = () => Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual("You entered negative number!", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void AreaOfTriangle_Ground6H2_Expected6()
        {
            //Arrange
            int ground = 6;
            int h = 2;

            //Act
            double result = Geometry.AreaOfTriangle(ground, h);

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AreaOfTriangle_LengthWidthNegative_ArgumentException()
        {
            //Arrange
            int legth = -6;
            int width = -22;

            //Act
            Action act = () => Geometry.AreaOfRectangle(legth, legth);

            //Assert
            Assert.AreEqual("You entered negative number!", Assert.ThrowsException<ArgumentException>(act).Message);

        }
    }
}
