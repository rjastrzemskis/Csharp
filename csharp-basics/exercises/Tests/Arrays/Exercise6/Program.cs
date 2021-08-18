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

            Random randNum = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randNum.Next(min, max);
                copyArray[i] = myArray[i];
            }

            myArray[myArray.Length-1] = -7;

            Console.WriteLine(string.Join(" ", myArray));
            Console.WriteLine(string.Join(" ", copyArray));
            Console.ReadKey();
        }
    }
}
