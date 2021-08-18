using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> soundList = new List<ISound> { new Firework(), new Parrot(), new Radio(), new Firework(), new Radio() };
            soundList.ForEach(x => x.PlaySound());
            Console.ReadKey();
        }
    }
}