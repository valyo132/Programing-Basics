using System;

namespace Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string townName = Console.ReadLine();
            string type = Console.ReadLine();
            string VIP = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                Environment.Exit(0);
            }

            switch (townName)
            {
                case "Bansko":
                case "Borovets":
                    switch (type)
                    {
                        case "noEquipment":
                            price += 80;
                            if (VIP == "yes")
                            {
                                price -= price * 0.05;
                            }
                            break;
                        case "withEquipment":
                            price += 100;
                            if (VIP == "yes")
                            {
                                price -= price * 0.1;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (type)
                    {
                        case "withBreakfast":
                            price += 130;
                            if (VIP == "yes")
                            {
                                price -= price * 0.12;
                            }
                            break;
                        case "noBreakfast":
                            price += 100;
                            if (VIP == "yes")
                            {
                                price -= price * 0.07;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            Environment.Exit(0);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Environment.Exit(0);
                    break;
            }
            double totalMoney = days * price;
            if (days > 7)
            {
                totalMoney -= price;
            }
            Console.WriteLine($"The price is {totalMoney:f2}lv! Have a nice time!");
        }
    }
}
