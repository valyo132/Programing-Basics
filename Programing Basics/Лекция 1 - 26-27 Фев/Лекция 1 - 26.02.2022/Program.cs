using System;

namespace Лекция_1___26._02._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double boq = double.Parse(Console.ReadLine());
            double nailon = double.Parse(Console.ReadLine());
            double razreditel = double.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double bonusboq = (boq + 1.1)* 14.5;
            double bonusrazreditel = razreditel * 5;
            double bonusnailon = (nailon + 2) * 1.5;
            double sum = bonusnailon + bonusrazreditel + bonusboq + 0.4;
            double pariNaChas = (sum * 0.3) * hours;
            double totalSum = pariNaChas + sum;
            Console.WriteLine(totalSum);
        }
    }
}
