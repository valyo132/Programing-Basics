using System;

namespace Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double neededFuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double totalMoney = 0;

            double moneyForFuel = neededFuel * 2.10;
            totalMoney = moneyForFuel + 100;

            switch (day)
            {
                case "Saturday":
                    totalMoney = totalMoney - totalMoney * 0.1;
                    break;
                case "Sunday":
                    totalMoney = totalMoney - totalMoney * 0.2;
                    break;
            }
            if (buget > totalMoney)
            {
                Console.WriteLine($"Safari time! Money left: {buget - totalMoney:f2} lv. ");
            }
            else
            {
                double neededMoney = Math.Abs(buget - totalMoney);
                Console.WriteLine($"Not enough money! Money needed: {neededMoney:f2} lv.");
            }
        }
    }
}
