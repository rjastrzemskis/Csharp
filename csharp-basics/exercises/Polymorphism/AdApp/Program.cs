using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Campaign c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, true));
            c.AddAdvert(new Poster(100, 12, 30, 100, 20));
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}