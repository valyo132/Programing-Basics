using System;

namespace Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());
            double points = 0;
            double wins = 0;
            double draws = 0;
            double looses = 0;

            if (matches == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
                Environment.Exit(0);
            }

            for (int i = 1; i <= matches; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        points += 3;
                        wins++;
                        break;
                    case "D":
                        points += 1;
                        draws++;
                        break;
                    case "L":
                        looses++;
                        break;
                }
            }
            double winRate = ((double)wins / (double)matches) * 100;

            Console.WriteLine($"{teamName} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {draws}");
            Console.WriteLine($"## L: {looses}");
            Console.WriteLine($"Win rate: {winRate:f2}%");
        }
    }
}
