﻿using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            int largestNumber = Math.Max(input1, Math.Max(input2, input3));

            Console.WriteLine("The largest number is " + largestNumber + "!.");
            Console.ReadKey();
        }
    }
}
