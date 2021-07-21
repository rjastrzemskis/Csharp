namespace Exercise9
{
    class Point
    {
        public int _x;
        public int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static void SwapPoints(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }
    }
}
