using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Janis", "Kalkis", "Saules iela 2 - 50", 1, 2.5);
            Employee employee = new Employee("Juris", "Kalnins", "Putru iela 4-5", 2, "Software Engineer");
            Persons persons = new Persons("Peteris", "Kumins", "Calu iela 2-1", 3);

            student.Display();
            employee.Display();
            persons.Display();
            Console.ReadKey();
        }
    }
}