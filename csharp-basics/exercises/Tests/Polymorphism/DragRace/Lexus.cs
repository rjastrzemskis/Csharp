using System;

namespace DragRace
{
    public class Lexus : Car , ModifiedCars
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

        public void UseNitrousOxideEngine() 
        {
            currentSpeed+=16;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}