using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            string userInput = "anything";
            while (userInput != string.Empty)
            {
                Console.Write("Enter name: ");
                uniqueNames.Add(userInput = Console.ReadLine());
            }

            Console.WriteLine("Unique name list contains: " + string.Join(" ", uniqueNames));
            Console.ReadKey();
        }
    }
}
