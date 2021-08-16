namespace Firm
{
    class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        //-----------------------------------------------------------------
        // Sets up an Commision with the specified information.
        //-----------------------------------------------------------------
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        //-----------------------------------------------------------------
        // Adds the specified number of sales to this employee's
        //-----------------------------------------------------------------
        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        //-----------------------------------------------------------------
        // Computes and returns the pay for this commission employee.
        //-----------------------------------------------------------------
        public override double Pay()
        {
            var payment = base.Pay() + _totalSales * _commissionRate;
            _totalSales = 0;
            return payment;
        }

        //-----------------------------------------------------------------
        // Returns information about an commision as a string.
        //-----------------------------------------------------------------
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nCurrent sales: " + _totalSales;
            return result;
        }
    }
}
