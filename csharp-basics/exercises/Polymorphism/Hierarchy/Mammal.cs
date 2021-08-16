namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string animalName, string animalType, double animalWeigth, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeigth, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public string GetSetLivingRegion
        {
            get { return _livingRegion; }
            set { _livingRegion = value; }
        }
    }
}
