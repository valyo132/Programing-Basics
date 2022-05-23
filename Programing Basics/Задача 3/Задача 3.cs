using System;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();
            string place = Console.ReadLine();
            double price = dancers * points;

            switch (seasson)
            {
                case "summer":
                    switch (place)
                    {
                        case "Bulgaria":
                            price -= price * 0.05;
                            break;
                        case "Abroad":
                            price += price * 0.5;
                            price -= price * 0.1;
                            break;
                    }
                    break;
                case "winter":
                    switch (place)
                    {
                        case "Bulgaria":
                            price -= price * 0.08;
                            break;
                        case "Abroad":
                            price += price * 0.5;
                            price -= price * 0.15;
                            break;
                    }
                    break;
            }
            double charity = price * 0.75;
            double left = price - charity;
            double moneyForDancers = left / dancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancers:f2}");
        }
    }
}
