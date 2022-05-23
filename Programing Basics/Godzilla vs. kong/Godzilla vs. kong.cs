using System;

namespace Godzilla_vs._kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int staff = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double dekor = neededMoney * 0.1;

            if (staff > 150)
            {
                price = price - price * 0.1;
            }

            double money = price * staff + dekor;
            if (money > neededMoney)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(money - neededMoney):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {neededMoney - money:f2} leva left.");
            }
        }
    }
}
