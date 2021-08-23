using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Test
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod()]
        public void CheckLastNumber_Range1To100ArrayLength_ExpectedTrue()
        {
            // Arrange
            int min = 1;
            int max = 100;
            int[] myArray = new int[10];
            int[] copyArray = new int[10];

            // Act
            ArrayExtensions.ChangeArrayLastNumber(min, max, myArray, copyArray);

            //Assert
            Assert.AreEqual(myArray[myArray.Length - 1], -7);
        }

        [TestMethod()]
        public void CheckArrayRange_Range1To100ArrayLength_ExpectedTrue()
        {
            // Arrange
            int min = 1;
            int max = 100;
            int[] myArray = new int[10];
            int[] copyArray = new int[10];

            // Act
            ArrayExtensions.ChangeArrayLastNumber(min, max, myArray, copyArray);

            //Assert
            for (int i = 0; i < myArray.Length; i++)
                Assert.IsTrue(Enumerable.Range(min, max).Contains(copyArray[i]));
        }

        [TestMethod()]
        public void CheckIfArraysAreSame_Range1To100ArrayLength_ExpectedTrue()
        {
            // Arrange
            int min = 1;
            int max = 100;
            int[] myArray = new int[10];
            int[] copyArray = new int[10];

            // Act
            ArrayExtensions.ChangeArrayLastNumber(min, max, myArray, copyArray);

            //Assert
            for (int i = 0; i < myArray.Length - 1; i++)
                Assert.AreEqual(myArray[i], copyArray[i]);
        }
    }
}