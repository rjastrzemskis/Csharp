using System;
using System.Globalization;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo currencyFormatUS = CultureInfo.CreateSpecificCulture("en-US");

            Console.Write("How much money is in the account?: ");
            double savingBalance = Convert.ToDouble(Console.ReadLine());
            SavingAccount account = new SavingAccount(savingBalance);

            Console.Write("Enter the annual interest rate: ");
            int monthlyInterest = Convert.ToInt32(Console.ReadLine());
            account.MonthlyInterest(monthlyInterest);

            Console.Write("How long has the account been opened? ");
            int accountOpened = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= accountOpened; i++)
            {
                Console.Write("Enter amount deposited for " + i + " month : ");
                double deposit = Convert.ToDouble(Console.ReadLine());
                account.Deposit(deposit);

                Console.Write("Enter amount withdrawn for " + i + ": ");
                double withdraw = Convert.ToInt32(Console.ReadLine());
                account.Withdrawal(withdraw);

                account.MonthlyInterestEarned();
            }

            Console.WriteLine("Total deposited: " + account.TotalDeposit().ToString("C", currencyFormatUS));
            Console.WriteLine("Total withdrawn: " + account.TotalWithdraw().ToString("C", currencyFormatUS));
            Console.WriteLine("Interest earned: " + account.TotalInterest().ToString("C", currencyFormatUS));
            Console.WriteLine("Ending balance: " + account.SavingBalance().ToString("C", currencyFormatUS));
            Console.ReadKey();
        }
    }
}
