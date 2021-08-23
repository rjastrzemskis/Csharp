using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneBook.Test
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        PhoneDirectory contact = new PhoneDirectory();

        [TestMethod]
        public void GetNumber_NameJurisNumber28542623_Expected28542623()
        {
            //Arrange
            contact.PutNumber("Juris", "28542623");

            //Act
            string result = contact.GetNumber("Juris");

            //Assert
            Assert.AreEqual("28542623", result);
        }

        [TestMethod]
        public void GetNumber_NameJurisNumber28542623_ArgumentException()
        {
            //Act
            Action act = () => contact.GetNumber("Peteris");

            //Assert
            Assert.AreEqual("There is no contact with that name!", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void GetName_NameJurisNumber28542623_ExpectedJuris()
        {
            //Act
            string result = contact.GetName("28542623");

            //Assert
            Assert.AreEqual("Juris", result);
        }

        [TestMethod]
        public void PutNumber_NameNullNumberNull_ArgumentException()
        {
            //Act
            Action act = () => contact.PutNumber(null,null );

            //Assert
            Assert.AreEqual("Name and number cannot be null", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void GetName_NameJurisNumber28542623NameKarlisNumber28542623_ArgumentException()
        {
            //Act
            Action act = () => contact.PutNumber("Karlis", "28542623");

            //Assert
            Assert.AreEqual("You already have contact with this number", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void GetName_NameJurisNumber2854262NameJurisNumber2561244_ArgumentException()
        {
            //Act
            Action act = () => contact.PutNumber("Juris", "2561244");

            //Assert
            Assert.AreEqual("You already have contact with this name", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void SortedDictionary_NameJurisNumber28542623NameAnnaNumber28542624_ExpectedSortedDictionary()
        {
            //Arrange
            contact.PutNumber("Anna", "28542624");

            //Act
            Dictionary<string, string> result = contact.SortedDictionary();

            //Assert
            string resultString = String.Empty;
            foreach (KeyValuePair<string, string> keyValues in result)
                resultString += keyValues.Key + " = " + keyValues.Value + " ";

            Assert.AreEqual("Anna = 28542624 Juris = 28542623", resultString.TrimEnd());
        }
    }
}
