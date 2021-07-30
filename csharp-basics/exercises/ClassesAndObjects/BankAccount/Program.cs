using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson", -17.50);
            benben.ShowUserNameAndBalance();
            Console.ReadKey();
        }
    }
}
