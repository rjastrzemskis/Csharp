using System;

namespace Exercise1
{
    class Product
    {
        private string _name;
        private int _amount;
        private decimal _price;

        public Product(string name, decimal price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;
        }

        public void StockInformation()
        {
            Console.WriteLine(_name + ", price " + _price + "$, amount " + _amount);
        }

        public void IncreaseAmount(int newAmount)
        {
            _amount+= newAmount;
        }

        public void DecreaseAmount(int newAmount)
        {
            _amount-= newAmount;
        }

        public void UpdatePrice(decimal newPrice)
        {
            _price = newPrice;
        }
    }
}
