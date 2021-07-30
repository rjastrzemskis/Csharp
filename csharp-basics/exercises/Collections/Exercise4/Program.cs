using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 1 && number != 4)
            {
                List <int> digits = ToListReverse(number);
                double sum = 0;
                int plus = 0;

                foreach (var digit in digits)
                {
                    Console.Write(digit + "^2 ");
                    sum += Math.Pow(digit, 2);
                    plus++;

                    if (digits.Count - plus != 0)
                        Console.Write("+ ");
                }
                Console.Write("= " + sum + "\n");
                number = (int)sum;
            }
            if (number == 1)
                Console.Write("Number is happy");
            else Console.Write("Number is not happy");

            Console.ReadKey();
        }

        public static List<int> ToListReverse(int number)
        {
            List<int> digits = new List<int>();
            while (number != 0)
            {
                digits.Add(number % 10);
                number = number / 10;
            }
            digits.Reverse();
            return digits;
        }
    }
}
