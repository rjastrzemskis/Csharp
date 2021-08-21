using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(OddCheck.isOdd(x));
            Console.ReadKey();
        }
    }
}