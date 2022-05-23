using System;

namespace Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countDrink = int.Parse(Console.ReadLine());
            double price = 0;

            switch (drink)
            {
                case "Espresso":
                    switch (sugar)
                    {
                        case "Without":
                            price += 0.9;
                            price -= price * 0.35;
                            break;
                        case "Normal":
                            price += 1;
                            break;
                        case "Extra":
                            price += 1.2;
                            break;
                    }
                    if (countDrink >= 5)
                    {
                        price -= price * 0.25;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            price += 1;
                            price -= price * 0.35;
                            break;
                        case "Normal":
                            price += 1.2;
                            break;
                        case "Extra":
                            price += 1.6;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            price += 0.5;
                            price -= price * 0.35;
                            break;
                        case "Normal":
                            price += 0.6;
                            break;
                        case "Extra":
                            price += 0.7;
                            break;
                    }
                    break;
            }
            double totalMoney = countDrink * price;
            if (totalMoney > 15)
            {
                totalMoney -= totalMoney * 0.2;
            }
            Console.WriteLine($"You bought {countDrink} cups of {drink} for {totalMoney:f2} lv.");
        }
    }
}
