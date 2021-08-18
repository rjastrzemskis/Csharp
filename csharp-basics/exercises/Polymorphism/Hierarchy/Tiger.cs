using System;

namespace Hierarchy
{
    class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "> ROAAR!";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Meat")
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
