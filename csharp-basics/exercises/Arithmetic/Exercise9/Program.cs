using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in pounds :");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in inches :");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight * 703 / Math.Pow(height, 2);

            if (BMI < 18.5)
                Console.WriteLine("Your BMI is " + BMI.ToString("F2") + " and you're underweight!");
            else if (BMI > 25)
                Console.WriteLine("Your BMI is " + BMI.ToString("F2") + " and you're overweighted!");
            else Console.WriteLine("Your BMI is " + BMI.ToString("F2") + " and it's optimal weight!");
            Console.ReadKey();
        }
    }
}