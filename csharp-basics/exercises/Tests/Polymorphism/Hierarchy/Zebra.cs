using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "> Ksaaa!";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Vegetable")
                GetSetFoodEaten += food.GetSetQuantity;
            else
                throw new ArgumentException("> " + GetSetAnimalType + "s are not eating that type of food!");

            return GetSetFoodEaten;
        }

        public override string ToString()
        {
            return "> " + GetSetAnimalType + "[" + GetSetAnimalName + ", " + GetSetAnimalWeigth + ", " + GetSetLivingRegion + ", " + GetSetFoodEaten + "]";
        }
    }
}
