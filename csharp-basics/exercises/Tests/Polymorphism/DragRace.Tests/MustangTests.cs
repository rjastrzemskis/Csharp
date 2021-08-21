using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class MustangTests
    {
        [TestMethod]
        public void CarName_Car_ExpectedCarName()
        {
            //Arrange
            Mustang Car = new Mustang();

            //Act
            string result = Car.CarName();

            //Assert
            Assert.AreEqual("Mustang", result);
        }

        [TestMethod]
        public void SpeedUp_CarSpeedUpBy16_Expected16()
        {
            //Arrange
            Mustang Car = new Mustang();

            //Act
            int result = Car.SpeedUp();

            //Assert
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void SpeedUp_CarSlowDownBy8_ExpectedMinus8()
        {
            //Arrange
            Mustang Car = new Mustang();

            //Act
            int result = Car.SlowDown();

            //Assert
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_CarSpeed0_Expected0()
        {
            //Arrange
            Mustang Car = new Mustang();

            //Act
            string result = Car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StarEngine_CarEngineOff_ExpectedEngineSound()
        {
            //Arrange
            Mustang Car = new Mustang();

            //Act
            string result = Car.StartEngine();

            //Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_CarEngineOff_Expected16()
        {
            //Arrange
            Mustang Car = new Mustang();

            //Act
            int result = Car.UseNitrousOxideEngine();

            //Assert
            Assert.AreEqual(20, result);
        }
    }
}
