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
                        List<string> citiesBeen = new List<string>();
                        string sanJose = "San Jose", newYork = "New York", anchorage = "Anchorage", honolulu = "Honolulu",
                                denver = "Denver", sanFrancisco = "San Francisco";

                        Console.WriteLine("From which city would you like to start? San Jose, New York, Anchorage, Honolulu, Denver, San Francisco");
                        string city = Console.ReadLine();

                        bool flying = true;
                        int flyingTimes = 0;
                        while (flying)
                        {
                            if (city == sanJose)
                                Console.WriteLine("You can fly from " + city + " to " + sanFrancisco + " or " + anchorage);
                            else if (city == newYork)
                                Console.WriteLine("You can fly from " + city + " to " + anchorage + ", " + sanJose + ", " + sanFrancisco + ", " + honolulu);
                            else if (city == anchorage)
                                Console.WriteLine("You can fly from " + city + " to " + newYork + " or " + sanJose);
                            else if (city == honolulu)
                                Console.WriteLine("You can fly from " + city + " to " + newYork + " or " + sanFrancisco);
                            else if (city == denver)
                                Console.WriteLine("You can fly from " + city + " to " + sanJose);
                            else if (city == sanFrancisco)
                                Console.WriteLine("You can fly from " + city + " to " + newYork + ", " + honolulu + ", " + denver);
                            else Console.WriteLine("There is no trip to this city! Try again!");

                            citiesBeen.Add(city);
                            Console.Write("Where will you fly next? ");
                            city = Console.ReadLine();

                            while (!flightsAvailable.Contains(citiesBeen[flyingTimes] + " -> " + city))
                            {
                                Console.WriteLine("There is no trip from " + citiesBeen[flyingTimes] + " to " + city);
                                Console.Write("Enter again destination : ");
                                city = Console.ReadLine();
                            }
                            flyingTimes++;

                            if (citiesBeen[0] == city)
                            {
                                citiesBeen.Add(city);
                                Console.WriteLine("Your route was " + string.Join(" -> ", citiesBeen));
                                flying = false;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong character. Try again!");
                        break;
                }
            } while (programIsWorking != userChoice);
        }
    }
}
