using System;

namespace DragRace
{
    public class Mustang : Car , ModifiedCars
    {
        private int currentSpeed = 0;

        public string CarName()
        {
            return GetType().Name;
        }

        public int SpeedUp()
        {
            return currentSpeed+=16;
        }

        public int SlowDown()
        {
            return currentSpeed-=8;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public int UseNitrousOxideEngine()
        {
            return currentSpeed += 20;
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}