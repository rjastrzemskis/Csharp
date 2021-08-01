using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            List<string> list = array.ToList();
            Console.WriteLine("List : " + string.Join(", ", list));

            HashSet<string> hashSet = array.ToHashSet();
            Console.WriteLine("Hashset: " + string.Join(", ", hashSet));

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (string brand in hashSet)
            {
                Console.Write("Enter " + brand + " origination : ");
                string origination = Console.ReadLine();
                dictionary.Add(brand, origination);
            }

            dictionary.ToList().ForEach(x => Console.WriteLine(x.Key + " -> " + x.Value));
            Console.ReadKey();
        }
    }
}
