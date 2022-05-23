using System;

namespace Easter_Launch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunaci = int.Parse(Console.ReadLine());
            int koraQica = int.Parse(Console.ReadLine());
            int kiloCookies = int.Parse(Console.ReadLine());

            double kozunakPrice = kozunaci * 3.2;
            double QicaPrise = koraQica * 4.35;
            double cookiePrice = kiloCookies * 5.40;
            double Qica = koraQica * 12 * 0.15;

            double total = kozunakPrice + QicaPrise + cookiePrice + Qica;
            Console.WriteLine($"{total:f2}");
        }
    }
}
