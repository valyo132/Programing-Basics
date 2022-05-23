using System;

namespace Подготовка_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());
            double awards = fee - fee * 0.3;
            double food = awards - awards * 0.15;
            double soundEfects = food / 2;
            double totalMonyNeeded = fee + awards + food + soundEfects;
            Console.WriteLine($"{totalMonyNeeded:f2}");
        }
    }
}
