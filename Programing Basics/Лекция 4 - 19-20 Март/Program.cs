using System;

namespace Лекция_4___19_20_Март
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double musala = 0, monblan = 0, kilimanjaro = 0, k2 = 0, everest = 0;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0; 

            int groups = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            for (int i = 1; i <= groups; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                totalPeople += countPeople;
                if (countPeople > 0 && countPeople <= 5)
                {
                    p1 += countPeople;
                }
                else if (countPeople >= 6 && countPeople <= 12)
                {
                    p2 += countPeople;
                }
                else if (countPeople >= 13 && countPeople <= 25)
                {
                    p3 += countPeople;
                }
                else if (countPeople >= 26 && countPeople <= 40)
                {
                    p4 += countPeople;
                }
                else
                {
                    p5 += countPeople;
                }
            }
            musala = (p1 / (double)totalPeople) * 100;
            monblan = (p2 / (double)totalPeople) * 100;
            kilimanjaro = (p3 / (double)totalPeople) * 100;
            k2 = (p4 / (double)totalPeople) * 100;
            everest = (p5 / (double)totalPeople) * 100;

            Console.WriteLine($"{musala:F2}%");
            Console.WriteLine($"{monblan:F2}%");
            Console.WriteLine($"{kilimanjaro:F2}%");
            Console.WriteLine($"{k2:F2}%");
            Console.WriteLine($"{everest:F2}%");
        }
    }
}
