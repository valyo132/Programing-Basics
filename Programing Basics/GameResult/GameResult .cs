using System;

namespace GameResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wins = 0, losts = 0, draws = 0;

            for (int i = 0; i <= 2; i++)
            {
                string GameResult = Console.ReadLine();
                char homeTeam = GameResult[0];
                char otherTeam = GameResult[2];

                if (homeTeam > otherTeam)
                {
                    wins++;
                }
                else if (homeTeam < otherTeam)
                { 
                    losts++;
                }
                else
                {
                    draws++;
                }
            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {losts} games.");
            Console.WriteLine($"Drawn games: {draws}");
        }
    }
}
