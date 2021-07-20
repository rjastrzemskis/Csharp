using System;

namespace Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Console.Write("Do you want to start to play? ");
            string answer = Console.ReadLine();

            int score = 0;
            bool playing = true;
            while (playing)
            {
                    Random random = new Random();
                    int randomNumber = random.Next(1, 6);

                    if (randomNumber == 1)
                    {
                        Console.WriteLine("You rolled a 1! You got 0 points. The game is over");
                        playing = false;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Your score is " + score + ". The game is over.");
                        playing = false;
                    }
                    else
                    { 
                    score += randomNumber;
                    Console.WriteLine("You rolled a " + randomNumber + "!");
                    Console.Write("Roll again? ");
                    answer = Console.ReadLine();
                    }
            }
            Console.ReadKey();
        }
    }
}