using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Your first account
            Account testAccount = new Account("Barto's account", 100.00);
            Console.WriteLine(testAccount);
            testAccount.Deposit(20);
            Console.WriteLine("Barto's account balance is now: " + testAccount.Balance() + "\n");

            //Your first money transfer
            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account",0);

            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            mattsAccount.Withdrawal(100.0);
            Console.WriteLine("Matt's account balance is now: " + mattsAccount.Balance());
            myAccount.Deposit(100.0);
            Console.WriteLine("My account balance is now: " + myAccount.Balance() + "\n");

            //Money transfer
            Account aAccount = new Account("A", 100.00);
            Account bAccount = new Account("B", 0);
            Account cAccount = new Account("C", 0);

            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Account.Transfer(aAccount,bAccount, 50.0);
            Account.Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }


    }
}
