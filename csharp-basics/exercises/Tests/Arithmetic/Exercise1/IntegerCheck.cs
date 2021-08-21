using System;

namespace Exercise1
{
    public class IntegerCheck
    {
        public static bool Numbers(int x, int y)
        {
            return (x == 15 || y == 15 || x + y == 15 || Math.Abs(x - y) == 15);
        }
    }
}
