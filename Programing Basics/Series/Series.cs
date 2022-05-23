using System;

namespace Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int seriesCount = int.Parse(Console.ReadLine());
            double moneyForSeries = 0;
            int count = 0;

            while (count < seriesCount)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                switch (name)
                {
                    case "Thrones":
                        price -= price * 0.5;
                        break;
                    case "Lucifer":
                        price -= price * 0.4;
                        break;
                    case "Protector":
                        price -= price * 0.3;
                        break;
                    case "TotalDrama":
                        price -= price * 0.2;
                        break;
                    case "Area":
                        price -= price * 0.1;
                        break;
                }
                moneyForSeries += price;
                count++;
            }
            if (buget >= moneyForSeries)
            {
                double moneyLeft = Math.Abs(buget - moneyForSeries);
                Console.WriteLine($"You bought all the series and left with {moneyLeft:f2} lv.");
            }
            else
            {
                double moneyNeeded = Math.Abs(buget - moneyForSeries);
                Console.WriteLine($"You need {moneyNeeded:f2} lv. more to buy the series!");
            }
        }
    }
}
