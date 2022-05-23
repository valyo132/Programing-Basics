using System;

namespace Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heigth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double perc = int.Parse(Console.ReadLine());

            double allTheWalls = heigth * width * 4;
            allTheWalls -= allTheWalls * (perc / 100);
            double spaceLeft = allTheWalls;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Tired!")
                {
                    Console.WriteLine($"{spaceLeft} quadratic m left.");
                    break;
                }
                double paint = double.Parse(command);
                spaceLeft -= paint;

                if (spaceLeft == 0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    break;
                }
                else if (spaceLeft < 0)
                {
                    double paintLeft = 0;
                    for (int i = 0; spaceLeft < 0; i++)
                    {
                        spaceLeft += 1;
                        paintLeft++;
                    }
                    Console.WriteLine($"All walls are painted and you have {paintLeft} l paint left!");
                    break;
                }
            }
        }
    }
}
