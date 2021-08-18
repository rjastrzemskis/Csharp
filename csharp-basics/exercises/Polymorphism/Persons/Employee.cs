using System;

namespace Persons
{
    class Employee : Persons
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobtitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobtitle;
        }

        public string GetSetJobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public override void Display()
        {
            Console.WriteLine(GetSetFirstName + " " + GetSetLastName + ", " + GetSetAddress + ", " + GetSetId + ", " + GetSetJobTitle);
        }
    }
}
