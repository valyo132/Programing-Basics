using System;

namespace Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double old = int.Parse(Console.ReadLine());
            double kid = int.Parse(Console.ReadLine());
            double priceForOld = double.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());

            double priceForKid = priceForOld - priceForOld * 0.7;
            priceForKid += fee;
            priceForOld += fee;

            double totalForTickets = priceForOld * old + priceForKid * kid;
            double income = totalForTickets * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {income:f2} lv.");
        }
    }
}
