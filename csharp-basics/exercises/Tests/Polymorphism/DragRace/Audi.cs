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

        public void SpeedUp() 
        {
            currentSpeed+=12;
        }

        public void SlowDown() 
        {
            currentSpeed-=6;
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