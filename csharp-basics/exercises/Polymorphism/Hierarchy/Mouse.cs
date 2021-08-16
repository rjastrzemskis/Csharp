using System;

namespace Hierarchy
{
    class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "> Piiii!";
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
            return "> " + GetSetAnimalType + "[" + GetSetAnimalName + ", " + GetSetAnimalWeigth + ", " + GetSetLivingRegion + ", " + GetSetFoodEaten + "]";
        }
    }
}
