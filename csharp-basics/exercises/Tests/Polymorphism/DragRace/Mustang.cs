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

        public void SpeedUp()
        {
            currentSpeed+=16;
        }

        public void SlowDown()
        {
            currentSpeed-=8;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 20;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}