using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date dayOff = new Date(19, 08, 2021);
            dayOff.DisplayDate();
            
            DateTest(dayOff);
            Console.WriteLine(dayOff.DisplayDate());
            Console.ReadKey();
        }

        private static void DateTest(Date dayOff)
        {
            Console.WriteLine("Enter new day off");
            Console.Write("Enter day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            dayOff.setDay(day);

            Console.Write("Enter month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            dayOff.setMonth(month);

            Console.Write("Enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            dayOff.setYear(year);
        }
    }
}