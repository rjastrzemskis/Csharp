using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;

            Car car1 = new Car(0);
            Car car2 = new Car(0);
            for (int i = 1; i <= 1; i++)
            {
                Console.Write("Enter bmw car " + i + " reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
                
                Console.Write("Enter audi car " + i + " reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car2.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Bmw car kilometers per liter are " + car1.CalculateConsumption() + " is gasHog:" + car1.GasHog());
            Console.WriteLine("Audi car Kilometers per liter are " + car2.CalculateConsumption()+ " is economyCar:" + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}
