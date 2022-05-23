using System;

namespace Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string packige = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;

            switch (movie)
            {
                case "John Wick":
                    switch (packige)
                    {
                        case "Drink":
                            price += tickets * 12;
                            break;
                        case "Popcorn":
                            price += tickets * 15;
                            break;
                        case "Menu":
                            price += tickets * 19;
                            break;
                    }
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Star Wars":
                    switch (packige)
                    {
                        case "Drink":
                            price += tickets * 18;
                            break;
                        case "Popcorn":
                            price += tickets * 25;
                            break;
                        case "Menu":
                            price += tickets * 30;
                            break;
                    }
                    if (tickets >= 4)
                    {
                        price = price - price * 0.3;
                    }
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
                case "Jumanji":
                    switch (packige)
                    {
                        case "Drink":
                            price += tickets * 9;
                            break;
                        case "Popcorn":
                            price += tickets * 11;
                            break;
                        case "Menu":
                            price += tickets * 14;
                            break;
                    }
                    if (tickets == 2)
                    {
                        price -= price * 0.15;
                    }
                    Console.WriteLine($"Your bill is {price:f2} leva.");
                    break;
            }
        }
    }
}
