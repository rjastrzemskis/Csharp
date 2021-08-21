namespace Exercise6
{
    public class CozaWozaLoza
    {
        public static string CozaLozaWozaSwap(int lowerBound, int upperBound)
        {
            string getAllWords = string.Empty;
            for (int number = lowerBound; number <= upperBound; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                    getAllWords += "CozaLoza ";
                else if (number % 3 == 0 && number % 7 == 0)
                    getAllWords += "CozaWoza ";
                else if (number % 3 == 0)
                    getAllWords += "Coza ";
                else if (number % 5 == 0)
                    getAllWords += "Loza ";
                else if (number % 7 == 0)
                    getAllWords += "Woza ";
                else getAllWords += number + " ";
                if (number % 11 == 0)
                    getAllWords += "\n";
            }
            return getAllWords.TrimEnd();
        }
    }
}
