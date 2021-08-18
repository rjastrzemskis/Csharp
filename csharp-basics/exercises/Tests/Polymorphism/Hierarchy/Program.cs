using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string ongoing = string.Empty;
            int animalCount = 0;

            while (ongoing != "End")
            {
                string[] animalInput = Console.ReadLine().Split(" ");
                string animalType = animalInput[0];
                string animalName = animalInput[1];
                double animalWeight = Convert.ToDouble(animalInput[2]);
                string livingRegion = animalInput[3];
                string nameSpace = System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace;

                if (animalType == "Cat")
                {
                    string catBreed = animalInput[4];
                    Type animalClassType = Type.GetType(nameSpace + "." + animalType, true);
                    animals.Add((Animal)Activator.CreateInstance(animalClassType, animalName, animalType, animalWeight, 0, livingRegion, catBreed));
                    Console.WriteLine(animals[animalCount].MakeSound());

                    string[] choiceFood = Console.ReadLine().Split(" ");
                    string foodType = choiceFood[0];
                    int foodQuantity = Convert.ToInt32(choiceFood[1]);
                    AddMeat(foodType, foodQuantity, animalCount, animals);
                }
                else
                {
                    Type animalClassType = Type.GetType(nameSpace + "." + animalType, true);
                    animals.Add((Animal)Activator.CreateInstance(animalClassType, animalName, animalType, animalWeight, 0, livingRegion));
                    Console.WriteLine(animals[animalCount].MakeSound());

                    string[] choiceFood = Console.ReadLine().Split(" ");
                    string foodType = choiceFood[0];
                    int foodQuantity = Convert.ToInt32(choiceFood[1]);
                    AddMeat(foodType, foodQuantity, animalCount, animals);
                }

                Console.WriteLine("> Do you want to keep adding new animals? Type End to stop and anything to continue.");
                animalType = Console.ReadLine();
                animalCount++;
                ongoing = animalType;
            }
            
            animals.ForEach(x => Console.WriteLine(x.ToString()));
            Console.ReadLine();
        }

        public static void AddMeat(string foodType, int foodQuantity, int animalCount, List<Animal> animals)
        {
            if (foodType == "Vegetable")
                animals[animalCount].Eat(new Vegetable(foodQuantity));
            else if (foodType == "Meat")
                animals[animalCount].Eat(new Meat(foodQuantity));

            Console.WriteLine(animals[animalCount].ToString());
        }
    }
}