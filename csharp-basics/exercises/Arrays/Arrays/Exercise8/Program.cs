using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {

        private static void Main(string[] args)
        {
            Initialize();
        }

        private static void Initialize()
        {
            Console.WriteLine("Welcome to hangman");
            string[] words = { "broken", "interest", "ten", "numerous" , "amazing" , "ten" , "boy" };

            Random rand = new Random();
            int randomWordNum = rand.Next(words.Length);
            string mysteryWord = words[randomWordNum];

            char[] hiddingWord = new char[mysteryWord.Length];
            for (int i = 0; i < mysteryWord.Length; i++)
                hiddingWord[i] = '_';

            Play(hiddingWord, mysteryWord);
        }

        private static void Play(char[] hiddingWord, string mysteryWord)
        {
            char[] mysteryWordCharrArr = mysteryWord.ToCharArray();
            string missedLetters = "";
            int missesAllowed = 10;

            while (missesAllowed > 0)
            {
                string unveilingWord = new string(hiddingWord);
                Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Tries left : " + missesAllowed);
                Console.WriteLine("Word : " + unveilingWord);
                Console.WriteLine("Misses : " + missedLetters);

                if (unveilingWord != mysteryWord)
                {
                    Console.Write("Guess: ");
                    char playerGuess = Console.ReadKey().KeyChar;
                    for (int i = 0; i < mysteryWord.Length; i++)
                    {
                        if (mysteryWordCharrArr.Contains(playerGuess))
                        {
                            if (mysteryWordCharrArr[i] == playerGuess)
                                hiddingWord[i] = playerGuess;
                        }
                        else
                        {
                            missedLetters += playerGuess;
                            missesAllowed = missesAllowed - 1;
                            i = mysteryWord.Length;
                        }
                    }
                }
                WinOrLose(unveilingWord, missesAllowed, mysteryWord);
            }
        }

        private static void WinOrLose(string unveilingWord, int missesAllowed , string mysteryWord)
        {
            if (missesAllowed == 0)
            {
                Console.WriteLine();
                Console.WriteLine("\nYou lost! Mystic Word was " + mysteryWord);
                Reset();
            }
            if (unveilingWord == mysteryWord)
            {
                Console.WriteLine();
                Console.WriteLine("\nYou got it! Mystic Word was " + mysteryWord);
                Reset();
            }
        }

        private static void Reset()
        {
            Console.Write("Wanna play again? y/n : ");
            string answer = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "y":
                    Console.Clear();
                    Initialize();
                    break;
                case "n":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid answer!");
                    Reset();
                    break;
            }
        }
    }
}