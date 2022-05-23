using System;

namespace Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double amounth = 0;
            int winCounter = 0, lostCounter = 0;
            double totalWin = 0;
            int winsForTheDay = 0, lostsForTheDay = 0;

            for (int i = 1; i <= days; i++)
            {
                while (true)
                {
                    string game = Console.ReadLine();
                    if (game == "Finish")
                    {
                        if (winCounter > lostCounter)
                        {
                            amounth += amounth * 0.1;
                        }
                        totalWin += amounth;
                        amounth= 0;
                        winsForTheDay += winCounter;
                        lostsForTheDay += lostCounter;
                        winCounter = 0;
                        lostCounter = 0;
                        break;
                    }
                    string result = Console.ReadLine();
                    switch (result)
                    {
                        case "win":
                            amounth += 20;
                            winCounter++;
                            break;
                        case "lose":
                            lostCounter++;
                            break;
                    }
                }
            }
            if (winsForTheDay > lostsForTheDay)
            {
                totalWin += totalWin * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalWin:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalWin:f2}");
            }
        }
    }
}
