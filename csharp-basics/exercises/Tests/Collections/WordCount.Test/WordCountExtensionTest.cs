using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCount.Test
{
    [TestClass]
    public class WordCountExtensionTest
    {
        [TestMethod]
        public void GetLines_TextFile_Expected6()
        {
            //Arrange
            string readWords = File.ReadAllText("..//..//lear.txt");

            //Act
            var result = WordCountExtension.GetLines(readWords);

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GetName_NameJurisNumber28542623_ExpectedJuris()
        {
            //Arrange
            string readWords = File.ReadAllText("..//..//lear.txt");

            //Act
            var result = WordCountExtension.GetWords(readWords);

            //Assert
            Assert.AreEqual(47, result);
        }

        [TestMethod]
        public void PutNumber_NameNullNumberNull_ArgumentException()
        {
            //Arrange
            string readWords = File.ReadAllText("..//..//lear.txt");
            int lines = 6;

            //Act
            var result = WordCountExtension.GetChars(readWords, lines);

            //Assert
            Assert.AreEqual(253, result);
        }
    }
}
