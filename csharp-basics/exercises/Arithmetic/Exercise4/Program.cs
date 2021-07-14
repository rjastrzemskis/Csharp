using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1ToN();
            Console.ReadKey();
        }

        static void Product1ToN()
        {
            int upperBound = 10;
            int lowerBound = 1;
            int sum = 1;

            for (int number = lowerBound; number <= upperBound; number++)
                sum *= number;

            Console.WriteLine("Product sum from 1 to 10 is " + sum);
        }
    }
}