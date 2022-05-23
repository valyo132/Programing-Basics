using System;

namespace Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wantedMoney = double.Parse(Console.ReadLine());
            double money = 0;

            while (money < wantedMoney)
            {
                string drinkName = Console.ReadLine();
                if (drinkName == "Party!")
                {
                    double neededMoney = Math.Abs(wantedMoney - money);
                    Console.WriteLine($"We need {neededMoney:f2} leva more.");
                    Console.WriteLine($"Club income - {money:f2} leva.");
                    Environment.Exit(0);
                    break;
                }
                int countDrinks = int.Parse(Console.ReadLine());
                double drinkPrice = drinkName.Length * countDrinks;
                if (drinkPrice % 2 != 0)
                {
                    drinkPrice -= drinkPrice * 0.25;
                }
                money += drinkPrice;
            }
            Console.WriteLine("Target acquired.");
            Console.WriteLine($"Club income - {money:f2} leva.");
        }
    }
}
