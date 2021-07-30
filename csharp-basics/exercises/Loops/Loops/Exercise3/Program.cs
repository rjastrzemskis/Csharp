using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSize = 20;
            int[] randomNumber = new int[numberSize];
            Random rnd = new Random();

            for (int i = 0; i < numberSize; i++)
            {
                randomNumber[i] = rnd.Next(0, 100);
            }

            Console.Write("There are few integers given: ");
            Console.WriteLine(string.Join(", ", randomNumber));
            Console.Write("Enter number to know it's position: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int numberFound = 0;
            if (Array.IndexOf(randomNumber, number) != -1)
                Console.WriteLine("Found " + number + " at position " + Array.IndexOf(randomNumber, number));
            else Console.WriteLine(numberFound + " it is not in array!");
            Console.ReadKey();
        }
    }
}