using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class VolkswagenTests
    {
        [TestMethod]
        public void CarName_Car_ExpectedCarName()
        {
            //Arrange
            Volkswagen Car = new Volkswagen();

            //Act
            string result = Car.CarName();

            //Assert
            Assert.AreEqual("Volkswagen", result);
        }

        [TestMethod]
        public void SpeedUp_CarSpeedUpBy10_Expected10()
        {
            //Arrange
            Volkswagen Car = new Volkswagen();

            //Act
            int result = Car.SpeedUp();

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SpeedUp_CarSlowDownBy5_ExpectedMinus5()
        {
            //Arrange
            Volkswagen Car = new Volkswagen();

            //Act
            int result = Car.SlowDown();

            //Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_CarSpeed0_Expected0()
        {
            //Arrange
            Volkswagen Car = new Volkswagen();

            //Act
            string result = Car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StarEngine_CarEngineOff_ExpectedEngineSound()
        {
            //Arrange
            Volkswagen Car = new Volkswagen();

            //Act
            string result = Car.StartEngine();

            //Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }
    }
}
