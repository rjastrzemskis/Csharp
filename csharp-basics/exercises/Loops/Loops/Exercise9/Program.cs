using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int desiredNumber = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int randomNumber1 = 0;
            int randomNumber2 = 0;
            while (randomNumber1 + randomNumber2 != desiredNumber)
            {
                randomNumber1 = random.Next(1, 6);
                randomNumber2 = random.Next(1, 6);

                int sum = randomNumber1 + randomNumber2;
                Console.WriteLine(randomNumber1 + " and " + randomNumber2 + " = " + sum);
            }
            Console.ReadKey();
        }
    }
}