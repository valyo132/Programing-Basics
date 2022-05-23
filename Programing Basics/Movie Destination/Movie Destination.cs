using System;

namespace Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string seasson = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            switch (seasson)
            {
                case "Winter":
                    switch (destination)
                    {
                        case "Dubai":
                            price += days * 45000;
                            break;
                        case "Sofia":
                            price += days * 17000;
                            break;
                        case "London":
                            price += days * 24000;
                            break;
                    }
                    break;
                case "Summer":
                    switch (destination)
                    {
                        case "Dubai":
                            price += days * 40000;
                            break;
                        case "Sofia":
                            price += days * 12500;
                            break;
                        case "London":
                            price += days * 20250;
                            break;
                    }
                    break;
            }
            if (destination == "Dubai")
            {
                price -= price * 0.3;
            }
            if (destination == "Sofia")
            {
                price += price * 0.25;
            }

            double totalPrice = Math.Abs(buget - price);
            if (buget > price)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice:f2} leva more!");
            }
        }
    }
}
