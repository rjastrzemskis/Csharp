using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravityCalculator.Test
{
    [TestClass]
    public class FinalPositionTests
    {
        [TestMethod]
        public void CheckFinalPosition_FallingTime10Velocity0Position0_Expected490_5()
        {
            // Arrange
            double fallingTime = 10.0;
            double initialVelocity = 0.0;
            double initialPosition = 0.0;

            // Act
            double result = FinalPosition.GetFinalPosition(fallingTime, initialVelocity, initialPosition);

            //Assert
            Assert.AreEqual(-490.5, result);
        }
    }
}
