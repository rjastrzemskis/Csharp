using System;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "English III", course2 = "Precalculus", course3 = "Music Theory", course4 = "Biotechnology", course5 = "Principles of Technology I",
                course6 = "Latin II", course7 = "AP US History", course8 = "Business Computer Information Systems";
            string teacher1 = "Ms. Lapan", teacher2 = "Mrs. Gideon", teacher3 = "Mr. Davis", teacher4 = "Ms. Palmer",
                teacher5 = "Ms. Garcia", teacher6 = "Mrs. Barnett", teacher7 = "Ms. Johannessen", teacher8 = "Mr. James";

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| 1 |                          " + course1 + " |       " + teacher1 + " |");
            Console.WriteLine("| 2 |                          " + course2 + " |     " + teacher2 + " |");
            Console.WriteLine("| 3 |                         " + course3 + " |       " + teacher3 + " |");
            Console.WriteLine("| 4 |                        " + course4 + " |      " + teacher4 + " |");
            Console.WriteLine("| 5 |           " + course5 + " |      " + teacher5 + " |");
            Console.WriteLine("| 6 |                             " + course6 + " |    " + teacher6 + " |");
            Console.WriteLine("| 7 |                        " + course7 + " | " + teacher7 + " |");
            Console.WriteLine("| 8 |" + course8 + " |       " + teacher8 + " |");
            Console.WriteLine("+------------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}