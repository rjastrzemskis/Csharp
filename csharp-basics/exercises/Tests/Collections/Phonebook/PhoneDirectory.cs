using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        public string _name;
        public string _number;

        public void GetNumber(string name)
        {
            _name = name;
            if (phoneBook.ContainsKey(_name))
                Console.WriteLine(_name + " number is " + phoneBook.FirstOrDefault(x => x.Key == _name).Value);
            else Console.WriteLine("There is no contact with name " + _name);
        }

        public void GetName(string number)
        {
            _number = number;
            if (phoneBook.ContainsValue(_number))
                Console.WriteLine(_number + " number is " + phoneBook.FirstOrDefault(x => x.Value == _number).Key);
            else Console.WriteLine("There is no contact with number " + _number);
        }

        public void PutNumber(string name, string number)
        {
            _name = name;
            _number = number;
            if (_name == null || _number == null)
                throw new Exception("Name and number cannot be null");
            else if (phoneBook.ContainsValue(_number))
                Console.WriteLine("You already have contact with this number");
            else if (phoneBook.ContainsKey(_name))
                Console.WriteLine("You already have contact with this name");

            phoneBook.Add(_name, _number);
            Console.WriteLine("You have created new contact");
        }

        public void SortedDictionary()
        {
            Console.WriteLine("Sorted phonebook by alphabet");
            Dictionary<string, string> sortedDictionary = phoneBook.OrderBy(key => key.Key).ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            sortedDictionary.ToList().ForEach(x => Console.WriteLine(x.Key + " = " + x.Value));

        }
    }
}