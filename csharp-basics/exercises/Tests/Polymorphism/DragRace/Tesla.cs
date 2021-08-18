using System;

namespace DragRace
{
    public class Tesla : Car
    {
        private int currentSpeed = 0;

        public string CarName()
        {
            return GetType().Name;
        }

        public void SpeedUp() 
        {
            currentSpeed+=15;
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
            Console.WriteLine("-- silence ---");
        }
    }
}