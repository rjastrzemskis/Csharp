using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter words with some uppercase: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    count++;
            }

            Console.WriteLine("There are " + count + " uppercase letters.");
            Console.ReadKey();
        }

    }
}