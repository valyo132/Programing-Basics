using System;

namespace Лекция_5_6_Март
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrize = double.Parse(Console.ReadLine());
            int bougthPuzzels = int.Parse(Console.ReadLine());
            int bougthDolls = int.Parse(Console.ReadLine());
            int bougthBears = int.Parse(Console.ReadLine());
            int bougthMinion = int.Parse(Console.ReadLine());
            int bougthTrucks = int.Parse(Console.ReadLine());

            int totalBougthToys = bougthBears + bougthDolls + bougthMinion + bougthPuzzels + bougthTrucks;
            double totalPrizeForToys = bougthBears * 4.10 + bougthDolls * 3 + bougthMinion * 8.20 + bougthPuzzels * 2.6 + bougthTrucks * 2;
            if (totalBougthToys >= 50)
            {
                totalPrizeForToys = totalPrizeForToys - totalPrizeForToys * 0.25;
                totalPrizeForToys = totalPrizeForToys - totalPrizeForToys * 0.10;
            }
            else
            {
                totalPrizeForToys = totalPrizeForToys - totalPrizeForToys * 0.10;
            }
            if (totalPrizeForToys > tripPrize)
            {
                Console.WriteLine($"Yes! {totalPrizeForToys - tripPrize:F2} lv left.");
            }
            else if (totalBougthToys < 50)
            {
                Console.WriteLine($"Not enough money! {tripPrize - totalPrizeForToys:F2} lv needed.");
            }
        }
    }
}
