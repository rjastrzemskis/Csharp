using System;

namespace Persons
{
    class Student : Persons
    {
        private double _gpa;

        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public double GetSetGpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public override void Display()
        {
            Console.WriteLine(GetSetFirstName + " " + GetSetLastName + ", " + GetSetAddress + ", " + GetSetId + ", " + GetSetGpa);
        }
    }
}
