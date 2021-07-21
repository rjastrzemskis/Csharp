namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double balance)
        {
            _name = name;
            _money = balance;
        }

        public double withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public double deposit(double i)
        {
            return _money += i;
        }

        public double balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
