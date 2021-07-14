using System;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a series of single digit numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                sum = sum + number % 10;
                number /= 10;
            }

            Console.WriteLine("Sum of all digits is " + sum);
            Console.ReadKey();

        }
    }
}