using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        public static string _name;
        public static string _number;

        public string GetNumber(string name)
        {
            _name = name;
            if (phoneBook.ContainsKey(_name))
                return phoneBook.FirstOrDefault(x => x.Key == _name).Value;
            else throw new ArgumentException("There is no contact with that name!");
        }

        public string GetName(string number)
        {
            _number = number;
            if (phoneBook.ContainsValue(_number))
                return phoneBook.FirstOrDefault(x => x.Value == _number).Key;
            else throw new ArgumentException("There is no contact with that number!");
        }

        public void PutNumber(string name, string number)
        {
            _name = name;
            _number = number;
            if (_name == null || _number == null)
                throw new ArgumentException("Name and number cannot be null");
            else if (phoneBook.ContainsValue(_number))
                throw new ArgumentException("You already have contact with this number");
            else if (phoneBook.ContainsKey(_name))
                throw new ArgumentException("You already have contact with this name");

            phoneBook.Add(_name, _number);
            Console.WriteLine("You have created new contact");
        }

        public Dictionary<string,string> SortedDictionary()
        {
             Dictionary<string, string> sortedDictionary = phoneBook.OrderBy(key => key.Key)
                .ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            sortedDictionary.ToList().ForEach(x => Console.WriteLine(x.Key + " = " + x.Value));
            return sortedDictionary;
        }
    }
}
