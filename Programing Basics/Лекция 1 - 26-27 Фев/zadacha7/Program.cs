using System;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            double chiken = 10.35;
            double fish = 12.40;
            double vegan = 8.15;
            double delivery = 2.5;

            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double prizeForChiken = chikenMenu * chiken;
            double prizeForFish = fishMenu * fish;
            double prizeForVegan = veganMenu * vegan;
            double desert = (prizeForChiken + prizeForFish + prizeForVegan) * 0.2;
            double sum = prizeForChiken + prizeForFish + prizeForVegan + desert + delivery;
            Console.WriteLine(sum);
        }
    }
}
