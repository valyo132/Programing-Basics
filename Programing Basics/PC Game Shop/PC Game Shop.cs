using System;

namespace PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            double game1 = 0, game2 = 0, game3 = 0, game4 = 0;

            for (int i = 1; i <= soldGames; i++)
            {
                string gameName = Console.ReadLine();
                switch (gameName)
                {
                    case "Hearthstone":
                        game1++;
                        break;
                    case "Fornite":
                        game2++;
                        break;
                    case "Overwatch":
                        game3++;
                        break;
                    default:
                        game4++;
                        break;
                }
            }
            double hearthstone = (game1 / (double)soldGames) * 100;
            double fornite = (game2 / (double)soldGames) * 100;
            double overwatch = (game3 / (double)soldGames) * 100;
            double others = (game4 / (double)soldGames) * 100;
            Console.WriteLine($"Hearthstone - {hearthstone:f2}%");
            Console.WriteLine($"Fornite - {fornite:f2}%");
            Console.WriteLine($"Overwatch - {overwatch:f2}%");
            Console.WriteLine($"Others - {others:f2}%");
        }
    }
}
