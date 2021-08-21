namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double balance)
        {
            _name = name;
            _money = balance;
        }

        public double Withdrawal(double i)
        {
            return _money -= i;
        }

        public double Deposit(double i)
        {
            return _money += i;
        }

        public double Balance()
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

        public static double Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            return to.Deposit(howMuch);
        }
    }
}
