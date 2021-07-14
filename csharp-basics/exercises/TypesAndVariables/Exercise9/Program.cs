using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in meters: ");
            int meters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double timeSeconds = (hours * 3600) + (minutes * 60) + seconds;
            double mps = meters / timeSeconds;
            double kph = (meters / 1000.0f) / (timeSeconds / 3600.0f);
            double mph = kph / 1.609f;

            Console.WriteLine("Your speed in meters/second is " + mps.ToString("F8"));
            Console.WriteLine("Your speed in km/h is " + kph.ToString("F8"));
            Console.WriteLine("Your speed in miles/h is " + mph.ToString("F8"));
            Console.ReadKey();
        }
    }
}