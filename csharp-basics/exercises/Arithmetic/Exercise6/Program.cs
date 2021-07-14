using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = 110;
            int lowerBound = 1;

            for (int number = lowerBound; number <= upperBound; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.Write("CozaLoza ");
                else if (number % 3 == 0 && number % 7 == 0)
                    Console.Write("CozaWoza ");
                else if (number % 3 == 0)
                    Console.Write("Coza ");
                else if (number % 5 == 0)
                    Console.Write("Loza ");
                else if (number % 7 == 0)
                    Console.Write("Woza ");
                else Console.Write(number + " ");
                if (number % 11 == 0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}