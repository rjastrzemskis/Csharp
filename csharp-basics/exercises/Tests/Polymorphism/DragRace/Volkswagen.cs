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

        public void SpeedUp()
        {
            currentSpeed+=10;
        }

        public void SlowDown()
        {
            currentSpeed-=5;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}