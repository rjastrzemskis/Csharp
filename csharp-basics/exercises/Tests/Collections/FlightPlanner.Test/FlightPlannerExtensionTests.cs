using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightPlanner.Test
{
    [TestClass]
    public class FlightPlannerExtensionTests
    {
        [TestMethod]
        public void NextDestination_CityCitiesBeenFlyingTimeFlightsAvailable_ExpectedDestinations()
        {
            //Arrange
            string city = "San Jose";
            List<string> citiesBeen = new List<string>() { "San Jose", "San Francisco", "New York" };
            //Act
            var result = FligthPlannerExtension.flighthTripAround(city, citiesBeen);

            //Assert
            Assert.AreEqual("You can fly from San Jose to San Francisco or Anchorage", result);
        }

        [TestMethod]
        public void NextDestination_CityCitiesBeenFlyingTimeFlightsAvailable_ArgumentException()
        {
            //Arrange
            string city = "Kakios";
            List<string> citiesBeen = new List<string>() { "San Jose", "San Francisco", "New York" };

            //Act
            Action act = () =>  FligthPlannerExtension.flighthTripAround(city, citiesBeen);

            //Assert
            Assert.AreEqual("There is no trip to this city!", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void AvailableTrip_CityCitiesBeenFlyingTimeFlightsAvailable_ExpectedNewCity()
        {
            //Arrange
            string city = "San Francisco";
            List<string> citiesBeen = new List<string>()
                { "San Jose", "San Francisco", "New York" };
            int flyingTimes = 2;
            List<string> flightsAvailable = new List<string>()
            {
                "San Jose -> San Francisco",
                "New York -> San Francisco",
                "San Francisco -> New York",
            };

            //Act
            List<string> result = FligthPlannerExtension.checkAvailableTrip(city, flyingTimes, flightsAvailable, citiesBeen);

            //Assert
            Assert.AreEqual("San Jose, San Francisco, New York, San Francisco", string.Join(", ", result));
        }

        [TestMethod]
        public void AvailableTrip_CityCitiesBeenFlyingTimeFlightsAvailable_ArgumentException()
        {
            //Arrange
            string city = "New York";
            List<string> citiesBeen = new List<string>() { "San Jose", "San Francisco", "New York" };
            int flyingTimes = 2;
            List<string> flightsAvailable = new List<string>()
            {
                "San Jose -> San Francisco",
                "New York -> San Francisco",
                "San Francisco -> New York",
            };

            //Act
            Action act = () => FligthPlannerExtension.checkAvailableTrip(city, flyingTimes, flightsAvailable, citiesBeen);

            //Assert
            Assert.AreEqual("There is no trip from New York to New York", Assert.ThrowsException<ArgumentException>(act).Message);
        }

        [TestMethod]
        public void RoundTrip_CityCitiesBeen_ExpectedFalse()
        {
            //Arrange
            string city = "San Jose";
            List<string> citiesBeen = new List<string>() { "San Jose", "San Francisco", "San Francisco", "New York" };

            //Act
            var result = FligthPlannerExtension.RoundTrip(city, citiesBeen);

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
