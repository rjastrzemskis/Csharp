using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            int age = 35;
            int height = 74;
            int weight = 180;
            double perInc = 2.54;
            double perPou = 0.45;
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height * perInc + " centimeter tall.");
            Console.WriteLine("He's " + weight * perPou + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + (height * perInc) + ", and " + (weight * perPou)
                               + " I get " + (age + (height * perInc) + (weight * perPou)) + ".");
            Console.ReadKey();
        }
    }
}