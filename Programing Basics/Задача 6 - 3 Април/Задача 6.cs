using System;

namespace Задача_6___3_Април
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0, standard = 0, kid = 0;
            int ticket = 0;
            double totalTicketsSold = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish") break;
                int freeSeets = int.Parse(Console.ReadLine());
                int ticketsSoldForFilm = 0;

                ticket = freeSeets;

                while (ticketsSoldForFilm < freeSeets)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        //Console.WriteLine($"{movie} - {fullPerc:f2}% full.");
                        break;
                    }

                    ticketsSoldForFilm++;
                    totalTicketsSold++;

                    switch (ticketType)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                }
                double fullPerc = (ticketsSoldForFilm / (double)freeSeets) * 100;
                Console.WriteLine($"{movie} - {fullPerc:f2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTicketsSold}");

            double studentTickets = (student / (double)totalTicketsSold) * 100;
            Console.WriteLine($"{studentTickets:f2}% student tickets.");

            double standardTickets = (standard / (double)totalTicketsSold) * 100;
            Console.WriteLine($"{standardTickets:f2}% standard tickets.");

            double kidTickets = (kid / (double)totalTicketsSold) * 100;
            Console.WriteLine($"{kidTickets:f2}% kids tickets.");
        }
    }
}
