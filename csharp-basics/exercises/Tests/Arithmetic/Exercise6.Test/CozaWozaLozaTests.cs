using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Test
{
    [TestClass]
    public class CozaWozaLozaTests
    {
        [TestMethod]
        public void IsCozaLozaWoza_LowerBound1Upper33_ExpectedString()
        {
            //Arrange
            int lowerBound = 1;
            int upperBound = 33;

            //Act
            string result = CozaWozaLoza.CozaLozaWozaSwap(lowerBound, upperBound);

            //Assert
            Assert.AreEqual("1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11 \n" +
                            "Coza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22 \n" +
                            "23 Coza Loza 26 Coza Woza 29 CozaLoza 31 32 Coza", result);
        }
    }
}
