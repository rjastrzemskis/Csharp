using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "..//..//flights.txt";

        private static void Main(string[] args)
        {
            string[] readText = File.ReadAllLines(Path);
            List<string> flightsAvailable = readText.ToList();

            char programIsWorking = '#';
            char userChoice = ' ';
            do
            {
                Console.WriteLine("To display list of available trips press 1");
                Console.WriteLine("To start your trip press 2");
                Console.WriteLine("To exit program press #");

                userChoice = Console.ReadKey().KeyChar;
                Console.Write("\b \b");
                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("List of available flights: ");
                        Console.WriteLine(string.Join("\n", flightsAvailable));
                        break;
                    case '2':
                        bool flying = true;
                        int flyingTimes = 0;
                        List<string> citiesBeen = new List<string>();
                        Console.WriteLine("From which city would you like to start? San Jose, New York, Anchorage, Honolulu, Denver, San Francisco");
                        string city = Console.ReadLine();
                        citiesBeen.Add(city);
                        while (flying)
                        {
                            Console.WriteLine(FligthPlannerExtension.flighthTripAround(city, citiesBeen));
                            Console.Write("Where will you fly next? ");
                            city = Console.ReadLine();
                            FligthPlannerExtension.checkAvailableTrip(city, flyingTimes, flightsAvailable, citiesBeen);
                            flying = FligthPlannerExtension.RoundTrip(city, citiesBeen);
                            flyingTimes++;
                        }

                        Console.WriteLine("Your route was " + string.Join(" -> ", citiesBeen));
                        break;
                    default:
                        Console.WriteLine("Wrong character. Try again!");
                        break;
                }
            } while (programIsWorking != userChoice);
        }
    }
}
