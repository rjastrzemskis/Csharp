using System;

namespace GravityCalculator
{
    public class FinalPosition
    {
        public static double GetFinalPosition(double fallingTime, double initialVelocity, double initialPosition)
        {
            double gravity = -9.81;
            return 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
        }
    }
}
