using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            return Math.PI * Math.Pow((double)radius, 2);
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            return (double)length * (double)width;
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            return (double)ground * (double)h * 0.5;
        }
    }
}
