using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxEmployee = 3;
            for (int employee = 1; employee <= maxEmployee; employee++)
            {
                Console.Write("Enter " + employee + " employee base pay: ");
                double basePay = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter " + employee + " employee worked hours: ");
                int hoursWorked = Convert.ToInt32(Console.ReadLine());

                double neededHours = 40;
                double overtimeRate = 1.5;
                double basePayMin = 8;
                double maxHours = 60;
                double totalSalary = 0;

                if ((basePay < basePayMin) || (hoursWorked > maxHours))
                    Console.WriteLine("There is error!");
                else if (hoursWorked > 40)
                {
                    totalSalary = basePay * neededHours + overtimeRate * basePay * (hoursWorked - neededHours);
                    Console.WriteLine("Employee " + employee + " have earned " + totalSalary + "$");
                }
                else
                {
                    totalSalary = basePay * hoursWorked;
                    Console.WriteLine("Employee " + employee + " have earned " + totalSalary + "$");
                }
            }
            Console.ReadKey();
        }
    }
}
