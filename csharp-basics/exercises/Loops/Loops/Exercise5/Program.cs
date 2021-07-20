using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string secondWord = Console.ReadLine();

            int firstWordLength = firstWord.Length;
            int secondWordLength = secondWord.Length;

            Console.WriteLine(firstWord + new string('.', (30 - firstWordLength - secondWordLength)) + secondWord);
            Console.ReadKey();
        }
    }
}