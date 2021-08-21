using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string readWords = File.ReadAllText("..//..//lear.txt");
            Console.WriteLine(readWords);
            Console.WriteLine("Lines = : " + WordCountExtension.GetLines(readWords));
            Console.WriteLine("Words = : " + WordCountExtension.GetWords(readWords));
            Console.WriteLine("Chars = : " + WordCountExtension.GetChars(readWords, WordCountExtension.GetLines(readWords)));
            Console.ReadLine();
        }
    }
}
