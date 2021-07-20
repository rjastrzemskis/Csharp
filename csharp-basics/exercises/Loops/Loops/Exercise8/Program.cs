using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int space = 0;

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i-1; j++)
                    Console.Write("////");
                for (int j = 0; j < space; j++)
                    Console.Write("****");
                for (int j = 0; j < i-1; j++)
                    Console.Write("\\\\\\\\");

                Console.WriteLine();
                space += 2;
            }
            Console.ReadLine();
        }
    }
}