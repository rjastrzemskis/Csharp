namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _currentKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _currentKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return _currentKilometers / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return 100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int kilometers, double liters)
        {
            _liters += liters;
            _currentKilometers += kilometers;
        }
    }
}
