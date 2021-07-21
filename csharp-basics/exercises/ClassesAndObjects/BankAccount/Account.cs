using System;
using System.Globalization;

namespace BankAccount
{
    class Account
    {
        CultureInfo currencyFormatUS = CultureInfo.CreateSpecificCulture("en-US");
        private string _name;
        private double _balance;
        
        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string name()
        {
            return _name;
        }

        public double balance()
        {
            return _balance;
        }
        public double negativeBalance()
        {
            return _balance = Math.Abs(_balance);
        }

        public void ShowUserNameAndBalance()
        {
            if (_balance >= 0)
                Console.WriteLine(name() + ", " + balance().ToString("C", currencyFormatUS));
            else Console.WriteLine(name() + ", -" + negativeBalance().ToString("C", currencyFormatUS));
        }
    }
}
