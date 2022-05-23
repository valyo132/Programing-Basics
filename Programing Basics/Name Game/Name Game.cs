using System;

namespace Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string winner = "";
            int max = 0;

            while (true)
            {
                string playerName = Console.ReadLine();
                if (playerName == "Stop")
                {
                    break;
                }
                int points = 0;
                for (int i = 0; i < playerName.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == playerName[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }
                if (points == max)
                {
                    winner = playerName;
                    max = points;
                }
                else if (points > max)
                {
                    max = points;
                    winner = playerName;
                }
            }
            Console.WriteLine($"The winner is {winner} with {max} points!");
        }
    }
}
