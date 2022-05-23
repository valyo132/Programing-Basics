using System;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nigths = int.Parse(Console.ReadLine());
            int travelCards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double MoneyForNights = nigths * 20;
            double MoneyForCards = travelCards * 1.6;
            double MoneyForTickets = tickets * 6;

            double totalMoney = MoneyForNights + MoneyForCards + MoneyForTickets;
            totalMoney = totalMoney * people;
            totalMoney += totalMoney * 0.25;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
