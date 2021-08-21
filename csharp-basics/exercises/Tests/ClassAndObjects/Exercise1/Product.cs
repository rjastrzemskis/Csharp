namespace Exercise1
{
    public class Product
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

        public string StockInformation()
        {
            return _name + ", price " + _price + "$, amount " + _amount;
        }

        public int IncreaseAmount(int newAmount)
        {
           return _amount+= newAmount;
        }

        public int DecreaseAmount(int newAmount)
        {
            return _amount-= newAmount;
        }

        public decimal UpdatePrice(decimal newPrice)
        { 
            return _price = newPrice;
        }
    }
}
