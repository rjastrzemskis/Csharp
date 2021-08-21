using System;
using System.Collections.Generic;

namespace FlightPlanner
{
    public class FligthPlannerExtension
    {
        public static string flighthTripAround(string city, List<string> citiesBeen)
        {
            string tripDestinatinChoice = string.Empty;
            string sanJose = "San Jose", newYork = "New York", anchorage = "Anchorage", honolulu = "Honolulu",
                denver = "Denver", sanFrancisco = "San Francisco";

            if (city == sanJose)
                tripDestinatinChoice = "You can fly from " + city + " to " + sanFrancisco + " or " + anchorage;
            else if (city == newYork)
                tripDestinatinChoice = "You can fly from " + city + " to " + anchorage + ", " + sanJose + ", " + sanFrancisco + ", " + honolulu;
            else if (city == anchorage)
                tripDestinatinChoice = "You can fly from " + city + " to " + newYork + " or " + sanJose;
            else if (city == honolulu)
                tripDestinatinChoice = "You can fly from " + city + " to " + newYork + " or " + sanFrancisco;
            else if (city == denver)
                tripDestinatinChoice = "You can fly from " + city + " to " + sanJose;
            else if (city == sanFrancisco)
                tripDestinatinChoice = "You can fly from " + city + " to " + newYork + ", " + honolulu + ", " + denver;
            else
                throw new ArgumentException("There is no trip to this city!");

            return tripDestinatinChoice;
        }

        public static List<string> checkAvailableTrip(string city, int flyingTimes, List<string> flightsAvailable, List<string> citiesBeen)
        {
            if (!flightsAvailable.Contains(citiesBeen[flyingTimes] + " -> " + city))
                throw new ArgumentException("There is no trip from " + citiesBeen[flyingTimes] + " to " + city);
            else
                citiesBeen.Add(city);

            return citiesBeen;
        }

        public static bool RoundTrip(string city, List<string> citiesBeen)
        {
            bool flying = true;
            if (citiesBeen[0] == city)
                flying = false;

            return flying;
        }
    }
}
