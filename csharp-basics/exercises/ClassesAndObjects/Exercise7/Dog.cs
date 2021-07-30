using System;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public void CreateDogs()
        {
            Console.WriteLine(_name + ", " + _sex);
        }

        public void DogsWithMotherAndFather()
        {
            Console.WriteLine(_name + " has " + _mother + " as mother, and " + _father + " as father");
        }

        public void FathersName()
        {
            if (_father == null)
                Console.WriteLine("Unknown");
            else Console.WriteLine(_father);
        }

        public void HasSameMotherAs(Dog name)
        {
            if (_mother == name._mother)
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}