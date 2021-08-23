﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Test
{
    [TestClass]
    public class IntegerCheckTests
    {
        [DataTestMethod]
        [DataRow(15, 0, true)]
        [DataRow(0, 15, true)]
        [DataRow(15, 15, true)]
        [DataRow(7, 8, true)]
        [DataRow(7, 22, true)]
        [DataRow(4, 7, false)]
        public void CheckIfNumberSumDifferenceOrSumIs15(int x, int y, bool expected)
        {
            // Act
            bool result = IntegerCheck.Numbers(x, y);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
