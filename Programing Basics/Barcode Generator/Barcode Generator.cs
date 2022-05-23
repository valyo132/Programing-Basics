using System;

namespace Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int a = start % 10, a1 = end % 10;
            start /= 10; end /= 10;
            int b = start % 10, b1 = end % 10;
            start /= 10; end /= 10;
            int c = start % 10, c1 = end % 10;
            start /= 10; end /= 10;
            int d = start % 10, d1 = end % 10;

            for (int i = d; i <= d1; i++)
            {
                for (int j = c; j <= c1; j++)
                {
                    for (int k = b; k <= b1; k++)
                    {
                        for (int p = a; p <= a1; p++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && p % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{p} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
