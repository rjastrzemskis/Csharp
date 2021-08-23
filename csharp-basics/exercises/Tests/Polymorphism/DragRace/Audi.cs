using System;

namespace DragRace
{
    public class Audi : Car
    {
        private int currentSpeed = 0;

        public string CarName()
        {
            return GetType().Name;
        }

        public int SpeedUp() 
        {
            return currentSpeed+=12;
        }

        public int SlowDown() 
        {
            return currentSpeed-=6;
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