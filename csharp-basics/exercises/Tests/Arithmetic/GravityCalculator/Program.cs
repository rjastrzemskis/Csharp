using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = FinalPosition.GetFinalPosition(fallingTime, initialVelocity, initialPosition);

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}