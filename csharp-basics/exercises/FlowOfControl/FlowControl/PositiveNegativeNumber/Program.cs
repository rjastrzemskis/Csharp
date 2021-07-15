using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int input1 = Convert.ToInt32(Console.ReadLine());

            if (input1 > 0)
                Console.WriteLine("Number is positive");
            else if (input1 < 0)
                Console.WriteLine("Number is negative");
            else
                Console.WriteLine("Number is zero");

            Console.ReadKey();
        }
    }
}
