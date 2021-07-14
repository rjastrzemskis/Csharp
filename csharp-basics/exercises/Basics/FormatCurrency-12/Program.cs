using System;

namespace FormatCurrency_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = "learning C sharp";
            var price = 19.99;
            var salesTax = CalculateSalesTax(price);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price: " + FormatCurrency(price));
            Console.WriteLine("Sales tax: " + FormatCurrency(salesTax));
            Console.WriteLine("Total: " + FormatCurrency(price + salesTax));
            Console.ReadKey();
        }

        static string FormatCurrency(double price)
        {
            return price.ToString("F2");
        }

        static double CalculateSalesTax(double price)
        {
            return price * 0.2;
        }
    }
}