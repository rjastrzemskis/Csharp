using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = getMenu();

                if (choice == 1)
                {
                    calculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    calculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    calculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nThanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("\nPlease enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
            }
            return userChoice;
        }

        public static void calculateCircleArea()
        {
            Console.WriteLine("\nWhat is the circle's radius? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var radius);

            Console.WriteLine("The circle's area is "
                    + Geometry.areaOfCircle(radius));
        }

        public static void calculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("\nEnter length? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out length);

            Console.WriteLine("Enter width? ");
            keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out width);

            Console.WriteLine("The rectangle's area is "
                    + Geometry.areaOfTriangle(length, width));
        }

        public static void calculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("\nEnter length of the triangle's base? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out ground);

            Console.WriteLine("Enter triangle's height? ");
            keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out height);

            Console.WriteLine("The triangle's area is "
                    + Geometry.areaOfRectangle(ground, height));
        }
    }
}