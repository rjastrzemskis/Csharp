using System;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public string GetSetBreed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public override string MakeSound()
        {
            return "> Meowwww!";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Meat" || food.ToString() == "Vegetable")
                GetSetFoodEaten += food.GetSetQuantity;
            else
                Console.WriteLine("> " + GetSetAnimalType + "s are not eating that type of food!");

            return GetSetFoodEaten;
        }

        public override string ToString()
        {
            return "> " + GetSetAnimalType + "[" + GetSetAnimalName + ", " + GetSetBreed + ", " + GetSetAnimalWeigth + ", " + GetSetLivingRegion + ", " + GetSetFoodEaten + "]";
        }
    }
}
