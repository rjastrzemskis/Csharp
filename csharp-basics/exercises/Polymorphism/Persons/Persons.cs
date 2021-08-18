using System;

namespace Persons
{
    class Persons
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Persons(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string GetSetFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string GetSetLastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string GetSetAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public int GetSetId
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine(GetSetFirstName + " " + GetSetLastName + ", " + GetSetAddress + ", " + GetSetId);
        }
    }
}
