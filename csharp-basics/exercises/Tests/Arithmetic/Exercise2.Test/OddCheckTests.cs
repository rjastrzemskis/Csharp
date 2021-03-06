using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise2.Test
{
    [TestClass]
    public class OddCheckTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(2, false)]
        [DataRow(3, true)]
        public void NumberIsOddOrNo_Numbers_ExpectedTrueorFalse(int x, bool expected)
        {
            // Act
            bool result = OddCheck.IsOdd(x);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
