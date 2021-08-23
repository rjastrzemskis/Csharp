using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            if (radius < 0)
                throw new ArgumentException("You entered negative number!");
            return Math.Round(Math.PI * Math.Pow((double)radius, 2), 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0)
                throw new ArgumentException("You entered negative number!");
            return Math.Round((double)length * (double)width, 2);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0)
                throw new ArgumentException("You entered negative number!");
            return Math.Round((double)ground * (double)h * 0.5, 2);
        }
    }
}
