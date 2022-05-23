using System;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tshirt = double.Parse(Console.ReadLine());
            double priceGoal = double.Parse(Console.ReadLine());

            double shorts = tshirt * 0.75;
            double socks = shorts * 0.2;
            double shoes = (tshirt + shorts) * 2;
            double total = tshirt + shorts + socks + shoes;
            total -= total * 0.15;

            if (total >= priceGoal)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
            }
            else
            {
                double neededMoney = priceGoal - total;
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededMoney:f2} lv. more.");
            }
        }
    }
}
