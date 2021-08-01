using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "..//..//lear.txt";
            string readWords = File.ReadAllText(filePath);
            Console.WriteLine(readWords);
        
            int lines = readWords.Split('\n').Length;
            Console.WriteLine("Lines = : " + lines);
            int words = Regex.Matches(readWords, @"((\w+(\s?)))").Count;
            Console.WriteLine("Words = : " + words);
            int chars = readWords.Length - lines + 1;
            Console.WriteLine("Chars = : " + chars);
            Console.ReadLine();
        }
    }
}
