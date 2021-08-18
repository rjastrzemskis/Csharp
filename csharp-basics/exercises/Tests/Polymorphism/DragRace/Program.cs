using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Car> carList = new List<Car> { new Audi(), new Bmw(), new Lexus(), new Mustang(), new Tesla(), new Volkswagen() };

            for (int i = 0; i < 10; i++)
            {
                foreach (Car model in carList)
                {
                    if (i == 0)
                    {
                        model.StartEngine();
                    }
                    else if (i == 2)
                    {
                        if (model is ModifiedCars)
                            ((ModifiedCars)model).UseNitrousOxideEngine();
                        else
                            model.SpeedUp();
                    }
                    else
                    {
                        model.SpeedUp();
                    }
                }
            }

            carList = carList.OrderByDescending(x => Int32.Parse(x.ShowCurrentSpeed())).ToList();
            Console.Write("The fastest car is " + carList.First().CarName() + " with speed of " + carList.First().ShowCurrentSpeed() + "km/h");
            Console.ReadKey();
        }
    }
}