using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "..//..//midtermscores.txt";
        private static void Main(string[] args)
        {
            String r00To09 = string.Empty, r10To19 = r00To09, r20To29 = r00To09, r30To39 = r00To09, r40To49 = r00To09, 
                r50To59 = r00To09, r60To69 = r00To09, r70To79 = r00To09, r80To89 = r00To09, r90To99 = r00To09, r100 = r00To09;

            string[] readText = File.ReadAllLines(Path);
            foreach (string examScore in readText)
            {
                List<int> examStatistic = examScore.Split(' ').Select(Int32.Parse).ToList();
                for (int student = 0; student < examStatistic.Count; student++)
                {
                    if (examStatistic[student] < 9)
                        r00To09 += "*";
                    else if (examStatistic[student] < 19 && examStatistic[student] > 9)
                        r10To19 += "*";
                    else if (examStatistic[student] < 29 && examStatistic[student] > 19)
                        r20To29 += "*";
                    else if (examStatistic[student] < 39 && examStatistic[student] > 29)
                        r30To39 += "*";
                    else if (examStatistic[student] < 49 && examStatistic[student] > 39)
                        r40To49 += "*";
                    else if (examStatistic[student] < 59 && examStatistic[student] > 49)
                        r50To59 += "*";
                    else if (examStatistic[student] < 69 && examStatistic[student] > 59)
                        r60To69 += "*";
                    else if (examStatistic[student] < 79 && examStatistic[student] > 69)
                        r70To79 += "*";
                    else if (examStatistic[student] < 89 && examStatistic[student] > 79)
                        r80To89 += "*";
                    else if (examStatistic[student] < 99 && examStatistic[student] > 89)
                        r90To99 += "*";
                    else r100 += "*";
                }

                Console.WriteLine("00-09: " + r00To09);
                Console.WriteLine("10-19: " + r10To19);
                Console.WriteLine("20-29: " + r20To29);
                Console.WriteLine("30-39: " + r30To39);
                Console.WriteLine("40-49: " + r40To49);
                Console.WriteLine("50-59: " + r50To59);
                Console.WriteLine("60-69: " + r60To69);
                Console.WriteLine("70-79: " + r70To79);
                Console.WriteLine("80-89: " + r80To89);
                Console.WriteLine("90-99: " + r90To99);
                Console.WriteLine("  100: " + r100);
                Console.ReadKey();
            }

        }
    }
}
