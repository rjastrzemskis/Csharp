using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of day , starting from 0 to 6: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            PrintDayInWordNested(dayNumber);
            PrintDayInWordSwitchCase(dayNumber);
            Console.ReadKey();
        }
        static void PrintDayInWordNested(int dayNumber)
        {
            string dayWord;
            if (0 == dayNumber)
                dayWord = "Sunday";
            else if (1 == dayNumber)
                dayWord = "Monday";
            else if (2 == dayNumber)
                dayWord = "Tuesday";
            else if (3 == dayNumber)
                dayWord = "Wednesday";
            else if (4 == dayNumber)
                dayWord = "Thursday";
            else if (5 == dayNumber)
                dayWord = "Friday";
            else if (6 == dayNumber)
                dayWord = "Saturday";
            else
                dayWord = "not a valid day";
            Console.WriteLine("Entered number is " + dayWord + " with nested approach.");
        }
        static void PrintDayInWordSwitchCase(int dayNumber)
        {
            string dayWord;
            switch (dayNumber)
            {
                case 0: dayWord = "Sunday"; break;
                case 1: dayWord = "Monday"; break;
                case 2: dayWord = "Tuesday"; break;
                case 3: dayWord = "Wednesday"; break;
                case 4: dayWord = "Thursday"; break;
                case 5: dayWord = "Friday"; break;
                case 6: dayWord = "Saturday"; break;
                default: dayWord = "not a valid day"; break;
            }
            Console.WriteLine("Entered number is " + dayWord + " with switch-case approach.");
        }
    }
}
