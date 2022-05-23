using System;

namespace Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawlberries = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double malini = double.Parse(Console.ReadLine());
            double kilogramstrawlberries = double.Parse(Console.ReadLine());

            double priceForMalini = strawlberries - strawlberries * 0.5;
            double priceForOranges = priceForMalini - priceForMalini * 0.4;
            double priceForBananas = priceForMalini - priceForMalini * 0.8;

            double totalPrice = strawlberries * kilogramstrawlberries + priceForMalini * malini + priceForBananas * bananas + priceForOranges * oranges;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
