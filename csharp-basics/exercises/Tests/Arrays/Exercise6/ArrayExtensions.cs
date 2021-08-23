using System;

namespace Exercise6
{
    public class ArrayExtensions
    {
        public static void ChangeArrayLastNumber(int min, int max, int[] myArray, int[] copyArray)
        {
            Random randNum = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randNum.Next(min, max);
                copyArray[i] = myArray[i];
            }

            myArray[myArray.Length - 1] = -7;
        }
    }
}