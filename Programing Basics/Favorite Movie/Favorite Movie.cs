using System;

namespace Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //грешни стойности на ASCII

            double points = 0;
            int count = 0;
            double max = double.MinValue;
            string topMovie = "";

            while (count < 7)
            {
                string movieName = Console.ReadLine();
                if (movieName == "STOP")
                {
                    break;
                }
                for (int i = 0; i <= movieName.Length-1; i++)
                {
                    int movieLength = movieName.Length;
                    char ch = movieName[i];
                    if (Char.IsUpper(ch))
                    {
                        points += movieName[i] - movieLength;
                    }
                    else
                    {
                        points += movieName[i] - movieLength * 2;
                    }
                }
                if (points > max)
                {
                    max = points;
                    topMovie = movieName;
                }
                count++;
                points = 0;
            }
            if (count == 7)
            {
                Console.WriteLine("The limit is reached.");
                Console.WriteLine($"The best movie for you is {topMovie} with {max} ASCII sum.");
            }
            else
            {
                Console.WriteLine($"The best movie for you is {topMovie} with {max} ASCII sum.");
            }
        }
    }
}
