namespace Exercise8
{
    class SavingAccount
    {
        private double _savingBalance;
        private double _monthlyInterestRate;
        private double _totalDeposit;
        private double _totalWithdraw;
        private double _totalInterest;

        public SavingAccount(double savingBalance)
        {
            _savingBalance = savingBalance;
        }

        public void Deposit(double deposite)
        {
            _savingBalance += deposite;
            _totalDeposit += deposite;
        }

        public double TotalDeposit()
        {
            return _totalDeposit;
        }

        public void Withdrawal(double withdrawal)
        {
            _savingBalance -= withdrawal;
            _totalWithdraw += withdrawal;
        }

        public double TotalWithdraw()
        {
            return _totalWithdraw;
        }

        public void MonthlyInterest(int monthlyInterest)
        {
            _monthlyInterestRate = (double)monthlyInterest / 12;
        }

        public double GetMonthlyInterestRate()
        {
            return _monthlyInterestRate;
        }

        public void MonthlyInterestEarned()
        {
            _totalInterest += _savingBalance * GetMonthlyInterestRate();
            _savingBalance += _savingBalance * GetMonthlyInterestRate();
        }

        public double TotalInterest()
        {
            return _totalInterest;
        }

        public double SavingBalance()
        {
            return _savingBalance;
        }
    }
}
