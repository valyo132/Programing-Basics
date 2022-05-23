using System;

namespace Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0;

            for (int i = 1; i <= countNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            double perc1 = ((double)p1 / (double)countNumbers) * 100;
            double perc2 = ((double)p2 / (double)countNumbers) * 100;
            double perc3 = ((double)p3 / (double)countNumbers) * 100;
            Console.WriteLine($"{perc1:f2}%");
            Console.WriteLine($"{perc2:f2}%");
            Console.WriteLine($"{perc3:f2}%");
        }
    }
}
