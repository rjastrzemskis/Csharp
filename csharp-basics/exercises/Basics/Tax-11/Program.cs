using System;

namespace Tax_11
{

    /**
     * Sales Tax
     *
     * A business requires a program that calculates how much sales tax to charge
     * Sales tax is 20% of the price of the product
     */
    class Program
    {
        static void Main(string[] args)
        {
            string product = "learning C sharp";
            var price = 19.99;
            var tax = 0.2;
            var salesTax = CalculateSalesTax(price, tax);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price: £" + price);
            Console.WriteLine("Sales tax: £" + salesTax.ToString("N2"));
            Console.WriteLine("Total: £" + (price + salesTax).ToString("N2"));
            Console.ReadKey();

        }

        //change only this method accordingly.
        static double CalculateSalesTax(double price, double tax)
        {
            return price * tax;
        }
    }
}