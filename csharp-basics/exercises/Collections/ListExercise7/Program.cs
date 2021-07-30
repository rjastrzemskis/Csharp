﻿using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            if (colors.Contains("White"))
                Console.WriteLine("Found the element");
            else Console.WriteLine("There is no such element");

            Console.ReadKey();
        } 
    }
}
