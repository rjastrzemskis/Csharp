using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 1;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                    sum *= n;
            }
            else if (n < 0)
            {
                for (int i = -1; i >= n; --i)
                    sum /= n;
            }
            else sum = 1;

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}