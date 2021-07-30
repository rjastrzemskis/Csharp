using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product first = new Product("Logitech mouse", (decimal)70.00, 14);
            Product second = new Product("iPhone 5s", (decimal)999.99, 3);
            Product third = new Product("Epson EB-U05", (decimal)440.46, 1);

            first.StockInformation();
            second.StockInformation();
            third.StockInformation();

            third.IncreaseAmount(2);
            first.DecreaseAmount(5);
            first.UpdatePrice((decimal)100.00);

            first.StockInformation();
            second.StockInformation();
            third.StockInformation();

            Console.ReadKey();
        }
    }
}
