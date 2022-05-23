using System;

namespace Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string srok = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int countMounths = int.Parse(Console.ReadLine());
            double price = 0;
            bool two = false;

            switch (srok)
            {
                case "one":
                    switch (type)
                    {
                        case "Small":
                            price += 9.98;
                            break;
                        case "Middle":
                            price += 18.99;
                            break;
                        case "Large":
                            price += 25.98;
                            break;
                        case "ExtraLarge":
                            price += 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (type)
                    {
                        case "Small":
                            price += 8.58;
                            break;
                        case "Middle":
                            price += 17.09;
                            break;
                        case "Large":
                            price += 23.59;
                            break;
                        case "ExtraLarge":
                            price += 31.79;
                            break;
                    }
                    two = true;
                    break;
            }
            if (internet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.5;
                }
                else if (price > 10 && price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }
            double totalPrice = price * (double)countMounths;
            if (two)
            {
                totalPrice = totalPrice - totalPrice * 0.0375;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
