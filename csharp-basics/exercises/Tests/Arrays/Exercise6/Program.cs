using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int[] myArray = new int[10];
            int[] copyArray = new int[10];

            ArrayExtensions.ChangeArrayLastNumber(min, max, myArray, copyArray);

            Console.WriteLine(string.Join(" ", myArray));
            Console.WriteLine(string.Join(" ", copyArray));
            Console.ReadKey();
        }
    }
}
