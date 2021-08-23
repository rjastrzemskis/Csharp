using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class BmwTests
    {
        [TestMethod]
        public void CarName_Car_ExpectedCarName()
        {
            //Arrange
            Bmw Car = new Bmw();

            //Act
            string result = Car.CarName();

            //Assert
            Assert.AreEqual("Bmw", result);
        }

        [TestMethod]
        public void SpeedUp_CarSpeedUpBy14_Expected14()
        {
            //Arrange
            Bmw Car = new Bmw();

            //Act
            int result = Car.SpeedUp();

            //Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void SpeedUp_CarSlowDownBy6_ExpectedMinus6()
        {
            //Arrange
            Bmw Car = new Bmw();

            //Act
            int result = Car.SlowDown();

            //Assert
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_CarSpeed0_Expected0()
        {
            //Arrange
            Bmw Car = new Bmw();

            //Act
            string result = Car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StarEngine_CarEngineOff_ExpectedEngineSound()
        {
            //Arrange
            Bmw Car = new Bmw();

            //Act
            string result = Car.StartEngine();

            //Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }
    }
}
