using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter employee base pay: ");
            double basePay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter employee worked hours: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.Write(EmployeeSalary.GetEmployeeSalary(basePay, hoursWorked));
            Console.ReadKey();
        }
    }
}