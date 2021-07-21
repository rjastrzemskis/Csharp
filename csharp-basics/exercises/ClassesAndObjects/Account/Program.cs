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
            testAccount.deposit(20);
            Console.WriteLine("Barto's account balance is now: " + testAccount.balance() + "\n");

            //Your first money transfer
            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account",0);

            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            mattsAccount.withdrawal(100.0);
            Console.WriteLine("Matt's account balance is now: " + mattsAccount.balance());
            myAccount.deposit(100.0);
            Console.WriteLine("My account balance is now: " + myAccount.balance() + "\n");

            //Money transfer
            Account aAccount = new Account("A", 100.00);
            Account bAccount = new Account("B", 0);
            Account cAccount = new Account("C", 0);

            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
