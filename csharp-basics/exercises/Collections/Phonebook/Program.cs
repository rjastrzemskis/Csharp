using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory contact = new PhoneDirectory();
            contact.PutNumber("Juris", "28542623");
            contact.PutNumber("Peteris", "28542555");

            contact.GetNumber("Juris");
            contact.GetNumber("Anna");

            contact.GetName("28542623");
            contact.GetName("11111111");

            contact.SortedDictionary();

            contact.PutNumber("Anna", "28524562");

            contact.SortedDictionary();
            Console.ReadKey();
        }
    }
}