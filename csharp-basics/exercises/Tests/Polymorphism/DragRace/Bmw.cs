using System;

namespace DragRace
{
    public class Bmw : Car
    {
        private int currentSpeed = 0;

        public string CarName()
        {
            return GetType().Name;
        }

        public int SpeedUp() 
        {
            return currentSpeed+=14;
        }

        public int SlowDown() 
        {
            return currentSpeed-=7;
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