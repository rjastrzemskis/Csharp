using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class TeslaTests
    {
        [TestMethod]
        public void CarName_Car_ExpectedCarName()
        {
            //Arrange
            Tesla Car = new Tesla();

            //Act
            string result = Car.CarName();

            //Assert
            Assert.AreEqual("Tesla", result);
        }

        [TestMethod]
        public void SpeedUp_CarSpeedUpBy15_Expected15()
        {
            //Arrange
            Tesla Car = new Tesla();

            //Act
            int result = Car.SpeedUp();

            //Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void SpeedUp_CarSlowDownBy7_ExpectedMinus7()
        {
            //Arrange
            Tesla Car = new Tesla();

            //Act
            int result = Car.SlowDown();

            //Assert
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_CarSpeed0_Expected0()
        {
            //Arrange
            Tesla Car = new Tesla();

            //Act
            string result = Car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StarEngine_CarEngineOff_ExpectedEngineSound()
        {
            //Arrange
            Tesla Car = new Tesla();

            //Act
            string result = Car.StartEngine();

            //Assert
            Assert.AreEqual("-- silence ---", result);
        }
    }
}
