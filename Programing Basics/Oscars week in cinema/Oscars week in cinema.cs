using System;

namespace Oscars_week_in_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string stageType = Console.ReadLine();
            int bougthTickets = int.Parse(Console.ReadLine());
            double totalMoneyForTheMovie = 0;

            switch (movie)
            {
                case "A Star Is Born":
                    switch (stageType)
                    {
                        case "normal":
                            totalMoneyForTheMovie = 7.5 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "luxury":
                            totalMoneyForTheMovie = 10.5 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "ultra luxury":
                            totalMoneyForTheMovie = 13.5 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (stageType)
                    {
                        case "normal":
                            totalMoneyForTheMovie = 7.35 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "luxury":
                            totalMoneyForTheMovie = 9.45 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "ultra luxury":
                            totalMoneyForTheMovie = 12.75 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                    }
                    break;
                case "Green Book":
                    switch (stageType)
                    {
                        case "normal":
                            totalMoneyForTheMovie = 8.15 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "luxury":
                            totalMoneyForTheMovie = 10.25 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "ultra luxury":
                            totalMoneyForTheMovie = 13.25 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (stageType)
                    {
                        case "normal":
                            totalMoneyForTheMovie = 8.75 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "luxury":
                            totalMoneyForTheMovie = 11.55 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                        case "ultra luxury":
                            totalMoneyForTheMovie = 13.95 * bougthTickets;
                            Console.WriteLine($"{movie} -> {totalMoneyForTheMovie:f2} lv.");
                            break;
                    }
                    break;
            }
        }
    }
}
