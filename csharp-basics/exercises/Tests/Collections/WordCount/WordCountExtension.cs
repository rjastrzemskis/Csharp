using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCountExtension
    {
        public static int GetLines(string readWords)
        {
            return readWords.Split('\n').Length;
        }

        public static int GetWords(string readWords)
        {
            return Regex.Matches(readWords, @"((\w+(\s?)))").Count;
        }

        public static int GetChars(string readWords,int lines)
        {
            return readWords.Length - lines + 1;
        }
    }
}
