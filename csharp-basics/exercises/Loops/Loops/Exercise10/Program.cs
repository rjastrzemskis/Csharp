using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max? ");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                    Console.Write(j);
                for (int j = i - 1; j >= 1; j--)
                    Console.Write(j);

                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}