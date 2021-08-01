﻿using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine(string.Join(",", colors));

            colors.Insert(1, "Cyan");
            colors.Insert(6, "Blue");
            colors.Insert(4, "Gray");

            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
