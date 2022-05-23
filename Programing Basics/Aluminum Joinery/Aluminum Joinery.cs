using System;

namespace Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joinery = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string withOrWithoutDelivery = Console.ReadLine();
            double price = 0;

            if (joinery < 10)
            {
                Console.WriteLine("Invalid order");
                Environment.Exit(0);
            }

            switch (size)
            {
                case "90X130":
                    price += 110 * joinery;
                    if (joinery > 30 && joinery < 60)
                    {
                        price -= price * 0.05;
                    }
                    else if (joinery > 60)
                    {
                        price -= price * 0.08;
                    }
                    break;
                case "100X150":
                    price += 140 * joinery;
                    if (joinery > 40 && joinery < 80)
                    {
                        price -= price * 0.06;
                    }
                    else if (joinery > 80)
                    {
                        price -= price * 0.1;
                    }
                    break;
                case "130X180":
                    price += 190 * joinery;
                    if (joinery > 20 && joinery < 50)
                    {
                        price -= price * 0.07;
                    }
                    else if (joinery > 50)
                    {
                        price -= price * 0.12;
                    }
                    break;
                case "200X300":
                    price += 250 * joinery;
                    if (joinery > 25 && joinery < 50)
                    {
                        price -= price * 0.09;
                    }
                    else if (joinery > 50)
                    {
                        price -= price * 0.14;
                    }
                    break;
            }
            if (withOrWithoutDelivery == "With delivery")
            {
                price += 60;
            }

            if (joinery > 99)
            {
                price -= price * 0.04;
            }

            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
