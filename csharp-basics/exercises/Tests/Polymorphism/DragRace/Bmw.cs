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

        public void SpeedUp() 
        {
            currentSpeed+=14;
        }

        public void SlowDown() 
        {
            currentSpeed-=7;
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