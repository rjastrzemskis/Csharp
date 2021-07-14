using System;

namespace ConvertCurrency_14
{
    class Program
    {

        /**
         * Currency Formatting
         *
         * The business is now breaking into the Brazilian market
         * Write a new function for converting to the Brazilian real
         * They have also decided that they should add a 1% fee to all foreign transactions
         * Find a way to add 1% to all currency conversions (think about the DRY principle)
         */

        static void Main(string[] args)
        {

            var product = "learning C sharp";
            var price = 12.5;
            var fee = 1.01;
            var echtousd = 1.4;
            var echtobrl = 5.6;
            var priceInUSD = ConvertToUSD(price, echtobrl, fee);
            var priceInBRL = ConvertToBRL(price, echtousd, fee);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price in USD: " + priceInUSD);
            Console.WriteLine("Price in BRL: " + priceInBRL);
            Console.ReadKey();
        }


        //change this method accordingly
        static string ConvertToUSD(double price, double echtobrl, double fee)
        {
            return (price * echtobrl * fee).ToString("N2");
        }

        //change this method accordingly
        static string ConvertToBRL(double price, double echtousd, double fee)
        {
            return (price * echtousd * fee).ToString("N2");
        }
    }
}