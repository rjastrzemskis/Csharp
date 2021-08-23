using System;

namespace DragRace
{
    public class Volkswagen : Car
    {
        private int currentSpeed = 0;

        public string CarName()
        {
            return GetType().Name;
        }

        public int SpeedUp()
        {
           return currentSpeed+=10;
        }

        public int SlowDown()
        {
            return currentSpeed-=5;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}