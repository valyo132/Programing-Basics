using System;

namespace Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double buget = double.Parse(Console.ReadLine());
            double secondBuget = buget;
            double spendMoney = 0;
            int count = 1;

            while (true)
            {
                string productName = Console.ReadLine();
                if (productName == "Stop")
                {
                    Console.WriteLine($"You bought {count - 1} products for {spendMoney:f2} leva.");
                    break;
                }
                double price = double.Parse(Console.ReadLine());
                if (count % 3 == 0)
                {
                    price = price - price * 0.5;
                }
                if (price > secondBuget)
                {
                    double neededMoney = Math.Abs(price - secondBuget);
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney:f2} leva!");
                    break;
                }
                spendMoney += price;
                secondBuget -= price;
                count++;
            }
        }
    }
}
