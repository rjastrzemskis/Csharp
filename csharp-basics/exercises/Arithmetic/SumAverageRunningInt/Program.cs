using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int lowerBound = 1;
            int upperBound = 100;

            for (int number = lowerBound; number <= upperBound; ++number)
                sum += number;

            double average = (double)sum / upperBound;

            Console.WriteLine("The sum of " + lowerBound + " to " + upperBound + " is " + sum);
            Console.WriteLine("The average is " + average);
            Console.ReadKey();
        }
    }
}