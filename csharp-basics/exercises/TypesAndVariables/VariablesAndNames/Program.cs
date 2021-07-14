using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            double seats_in_a_car = 4.0;
            int drivers = 28;
            int passengers = 90;
            int cars_not_driven = cars - drivers;
            double cars_driven = drivers;
            double carpool_capacity = drivers * seats_in_a_car;
            double average_passengers_per_car = passengers / cars_driven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car.ToString("F2") + " in each car.");
            Console.ReadKey();
        }
    }
}