using System;

namespace Excersice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int year = minutes / 525600;
            int day = minutes / 1440;
            int remain = day % 525600;

            Console.WriteLine(minutes + " minutes are " + year + " years and " + remain + " days ");
            Console.ReadKey();

        }
    }
}