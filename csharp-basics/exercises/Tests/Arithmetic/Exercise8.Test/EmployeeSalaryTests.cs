using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Test
{
    [TestClass]
    public class EmployeeSalaryTests
    {
        [DataTestMethod]
        [DataRow(7, 4, "There is error!")]
        [DataRow(12, 70, "There is error!")]
        [DataRow(10, 50, "Employee have earned 550$")]
        [DataRow(9, 20, "Employee have earned 180$")]
        public void WorksMoreThan60HoursOrEarnsLessThan7_BasePayHoursWorked_ExpectedErorOrSalary(int basePay, int hoursWorked, string expected)
        {
            //Assert
            Assert.AreEqual(expected, EmployeeSalary.GetEmployeeSalary(basePay, hoursWorked));
        }
    }
}
