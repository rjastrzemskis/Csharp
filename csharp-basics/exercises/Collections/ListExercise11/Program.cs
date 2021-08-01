using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            names.Add("Janis");
            names.Add("Peteris");
            names.Add("Juris");
            names.Add("Anna");
            names.Add("Jana");
            names.Add("Uldis");
            names.Add("Karlis");
            names.Add("Rolands");
            names.Add("Anita");
            names.Add("Andris");
            Console.WriteLine(string.Join(",", names));

            names.Insert(4, "Ieva");
            Console.WriteLine(string.Join(",", names));

            names[names.Count - 1] = "Edgars";
            Console.WriteLine(string.Join(",", names));

            names.Sort();
            Console.WriteLine(string.Join(",", names));

            if (names.Contains("Foobar"))
                Console.WriteLine("Found the element");
            else Console.WriteLine("There is no such element");

            foreach(string name in names)
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
