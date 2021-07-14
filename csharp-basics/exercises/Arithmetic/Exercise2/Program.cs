using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isOdd(x));
            Console.ReadKey();
        }

        public static string isOdd(int number)
        {
            return (number % 2 == 1) ? "Odd Number" : "bye!";
        }
    }
}