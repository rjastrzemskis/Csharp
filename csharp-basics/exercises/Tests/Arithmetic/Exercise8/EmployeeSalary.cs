namespace Exercise8
{
    public class EmployeeSalary
    {
        public static string GetEmployeeSalary(double basePay,int hoursWorked)
        {
            double neededHours = 40;
            double overtimeRate = 1.5;
            double basePayMin = 8;
            double maxHours = 60;
            double totalSalary = 0;

            if ((basePay < basePayMin) || (hoursWorked > maxHours))
                return "There is error!";
            else if (hoursWorked > 40)
            {
                totalSalary = basePay * neededHours + overtimeRate * basePay * (hoursWorked - neededHours);
                return "Employee have earned " + totalSalary + "$";
            }
            else
            {
                totalSalary = basePay * hoursWorked;
                return "Employee have earned " + totalSalary + "$";
            }
        }
    }
}
