using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class LexusTests
    {
        [TestMethod]
        public void CarName_Car_ExpectedCarName()
        {
            //Arrange
            Lexus Car = new Lexus();

            //Act
            string result = Car.CarName();

            //Assert
            Assert.AreEqual("Lexus", result);
        }

        [TestMethod]
        public void SpeedUp_CarSpeedUpBy12_Expected12()
        {
            //Arrange
            Lexus Car = new Lexus();

            //Act
            int result = Car.SpeedUp();

            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void SpeedUp_CarSlowDownBy6_ExpectedMinus6()
        {
            //Arrange
            Lexus Car = new Lexus();

            //Act
            int result = Car.SlowDown();

            //Assert
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_CarSpeed0_Expected0()
        {
            //Arrange
            Lexus Car = new Lexus();

            //Act
            string result = Car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StarEngine_CarEngineOff_ExpectedEngineSound()
        {
            //Arrange
            Lexus Car = new Lexus();

            //Act
            string result = Car.StartEngine();

            //Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_CarEngineOff_Expected16()
        {
            //Arrange
            Lexus Car = new Lexus();

            //Act
            int result = Car.UseNitrousOxideEngine();

            //Assert
            Assert.AreEqual(16, result);
        }
    }
}
