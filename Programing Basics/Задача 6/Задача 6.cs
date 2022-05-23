using System;

namespace Задача_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int c = number % 10;
            number /= 10;
            int b = number % 10;
            number /= 10;
            int a = number % 10;

            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}
