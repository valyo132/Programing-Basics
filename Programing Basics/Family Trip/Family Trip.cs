using System;

namespace Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 90/100

            double buget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceForNigth = int.Parse(Console.ReadLine());
            int perc = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                priceForNigth = priceForNigth - priceForNigth * 0.05;
            }
            double totalForNights = priceForNigth * nights;
            double otherStuff = buget * ((double)perc / 100);

            double totalMoney = totalForNights + otherStuff;
            if (buget >= totalMoney)
            {
                double moneyLeft = buget - totalMoney;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else
            {
                double moneyNeeded = Math.Abs(buget - totalMoney);
                Console.WriteLine($"{moneyNeeded:f2} leva needed.");
            }
        }
    }
}
