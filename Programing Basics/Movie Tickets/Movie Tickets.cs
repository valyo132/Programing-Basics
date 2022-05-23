using System;

namespace Movie_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char symbol = ' ';
            int symbol2 = 0;
            int symbol3 = 0;
            int symbol4 = 0;

            for (int i = a1; i <= a2 - 1; i++)
            {
                symbol = (char)i;
                symbol4 = i;
                for (int j = 1; j <= n - 1; j++)
                {
                    symbol2 = j;
                    for (int k = 1; k <= n / 2 - 1; k++)
                    {
                        symbol3 = k;
                        int sum = symbol2 + symbol3 + symbol4;
                        if (symbol4 % 2 != 0 && sum % 2 != 0)
                        {
                            Console.WriteLine($"{symbol}-{symbol2}{symbol3}{symbol4}");
                        }
                    }
                }
            }
        }
    }
}
