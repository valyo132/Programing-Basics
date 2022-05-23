using System;

namespace Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());
            double points = 0;
            int red = 0, orage = 0, yellow = 0, white = 0,black = 0, other = 0;

            for (int i = 1; i <= balls; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        points += 5;
                        red++;
                        break;
                    case "orange":
                        points += 10;
                        orage++;
                        break;
                    case "yellow":
                        points += 15;
                        yellow++;
                        break;
                    case "white":
                        points += 20;
                        white++;
                        break;
                    case "black":
                        points = Math.Floor(points / 2);
                        black++;
                        break;
                    default:
                        other++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orage}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
