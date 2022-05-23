using System;

namespace Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantedMovies = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = double.MaxValue;
            string highiestRaiting = "";
            string lowiestRaiting = "";
            double totalRaiting = 0;

            for (int i = 0; i < wantedMovies; i++)
            {
                string movieName = Console.ReadLine();
                double raiting = double.Parse(Console.ReadLine());

                if (raiting > max)
                {
                    highiestRaiting = movieName;
                    max = raiting;
                }
                if (raiting < min)
                {
                    lowiestRaiting = movieName;
                    min = raiting;
                }
                totalRaiting += raiting;
            }
            double avarageRaiting = totalRaiting / wantedMovies;

            Console.WriteLine($"{highiestRaiting} is with highest rating: {max:f1}");
            Console.WriteLine($"{lowiestRaiting} is with lowest rating: {min:f1}");

            Console.WriteLine($"Average rating: {avarageRaiting:f1}");
        }
    }
}
