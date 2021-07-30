using System;

namespace EnergyDrinks
{
    class EnergyDrinks
    {
        private int _numberedSurveyed = 12467;
        private double _purchasedEnergyDrinks = 0.14;
        private double _preferCitrusDrinks = 0.64;

        public EnergyDrinks(int numberedSurveyed, double purchasedEnergyDrinks, double preferCitrusDrinks)
        {
            _numberedSurveyed = numberedSurveyed;
            _purchasedEnergyDrinks = purchasedEnergyDrinks;
            _preferCitrusDrinks = preferCitrusDrinks;
        }

        public double CalculateEnergyDrinkers()
        {
            return (double)_numberedSurveyed * _purchasedEnergyDrinks;
        }

        public double CalculatePreferCitrus()
        {
            return  CalculateEnergyDrinkers() * _preferCitrusDrinks;
        }

        public void DisplaySurveyResults()
        {
            Console.WriteLine("Total number of people surveyed " + _numberedSurveyed);
            Console.WriteLine("Approximately " + CalculateEnergyDrinkers().ToString("F0") + " bought at least one energy drink"); ;
            Console.WriteLine(CalculatePreferCitrus().ToString("F0") + " of those " + "prefer citrus flavored energy drinks.");
        }
    }
}
