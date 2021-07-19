using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };
            int numToFind = 1245;
            bool test = false;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == numToFind)
                {
                    test = true;
                    break;
                }
            }

            if (test)
                Console.WriteLine("Contains!");
            else
                Console.WriteLine("Does not contain!");

            Console.ReadKey(); 
        }
    }
}
