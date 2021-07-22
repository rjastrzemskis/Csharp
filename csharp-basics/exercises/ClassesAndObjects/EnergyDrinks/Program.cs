using System;

namespace EnergyDrinks
{
    class Program
    {
        private static void Main(string[] args)
        {
            EnergyDrinks survey = new EnergyDrinks(12467, 0.14, 0.64);
            survey.DisplaySurveyResults();
            Console.ReadKey();
        }
    }
}
