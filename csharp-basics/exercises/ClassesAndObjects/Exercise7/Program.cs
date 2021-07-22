using System;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male", "Lady", "Rocky");
            Dog rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog sparky = new Dog("Sparky", "male", null, null);
            Dog buster = new Dog("Buster", "male", "Lady", "Sparky");
            Dog sam = new Dog("Sam", "male", null, null);
            Dog lady = new Dog("Lady", "female", null, null);
            Dog molly = new Dog("Molly", "female", null, null);
            Dog coco = new Dog("Coco", "female", "Molly", "Buster");

            max.CreateDogs();
            rocky.CreateDogs();
            sparky.CreateDogs();
            buster.CreateDogs();
            sam.CreateDogs();
            lady.CreateDogs();
            molly.CreateDogs();
            coco.CreateDogs();

            max.DogsWithMotherAndFather();
            coco.DogsWithMotherAndFather();
            rocky.DogsWithMotherAndFather();
            buster.DogsWithMotherAndFather();

            coco.FathersName();
            sparky.FathersName();

            coco.HasSameMotherAs(rocky);

            Console.ReadKey();
        }
    }
}
