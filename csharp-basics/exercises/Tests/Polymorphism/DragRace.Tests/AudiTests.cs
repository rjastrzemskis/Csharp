using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class AudiTests
    {
        [TestMethod]
        public void CarName_Car_ExpectedCarName()
        {
            //Arrange
            Audi Car = new Audi();

            //Act
            string result = Car.CarName();

            //Assert
            Assert.AreEqual("Audi", result);
        }

        [TestMethod]
        public void SpeedUp_CarSpeedUpBy12_Expected12()
        {
            //Arrange
            Audi Car = new Audi();

            //Act
            int result = Car.SpeedUp();

            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void SpeedUp_CarSlowDownBy6_ExpectedMinus6()
        {
            //Arrange
            Audi Car = new Audi();

            //Act
            int result = Car.SlowDown();

            //Assert
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_CarSpeed0_Expected0()
        {
            //Arrange
            Audi Car = new Audi();

            //Act
            string result = Car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StarEngine_CarEngineOff_ExpectedEngineSound()
        {
            //Arrange
            Audi Car = new Audi();

            //Act
            string result = Car.StartEngine();

            //Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }
    }
}
