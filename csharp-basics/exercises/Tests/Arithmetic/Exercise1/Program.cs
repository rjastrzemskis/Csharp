using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first digit: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second digit: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IntegerCheck.Numbers(x, y));
            Console.ReadKey();
        }
    }
}