using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any letter :");
            char letter = Console.ReadLine().ToLower().ToCharArray()[0];
            PhoneKeyPadNested(letter);
            PhoneKeyPadSwitchCase(letter);
            Console.ReadKey();
        }
        static void PhoneKeyPadNested(char letter)
        {
            int digit = 0;
            if (letter >= 'a' && letter <= 'w')
            {
                if (letter >= 'a' && letter <= 'c')
                    digit = 2;
                else if (letter >= 'd' && letter <= 'f')
                    digit = 3;
                else if (letter >= 'g' && letter <= 'i')
                    digit = 4;
                else if (letter >= 'j' && letter <= 'l')
                    digit = 5;
                else if (letter >= 'm' && letter <= 'o')
                    digit = 6;
                else if (letter >= 'p' && letter <= 's')
                    digit = 7;
                else if (letter >= 't' && letter <= 'v')
                    digit = 8;
                else if (letter >= 't' && letter <= 'w')
                    digit = 9;
                Console.WriteLine("Entered letter is located on number " + digit + " with nested approach.");
            }
            else Console.WriteLine("It is not a letter!");
        }
        static void PhoneKeyPadSwitchCase(char letter)
        {
            int digit = 0;
            if (Char.IsLetter(letter))
            { 
            switch (letter)
            {
                case 'a': case 'b': case 'c': digit = 2; break;
                case 'd': case 'e': case 'f': digit = 3; break;
                case 'g': case 'h': case 'i': digit = 4; break;
                case 'j': case 'k': case 'l': digit = 5; break;
                case 'm': case 'n': case 'o': digit = 6; break;
                case 'p': case 'q': case 'r': case 's': digit = 7; break;
                case 't': case 'u': case 'v': digit = 8; break;
                case 'w': case 'x': case 'y': case 'z': digit = 9; break;
                default : break;
            }
                Console.WriteLine("Entered letter is located on number " + digit + " with switch-case approach.");
            }
            else Console.WriteLine("It is not a letter!");
        }
    }
}
