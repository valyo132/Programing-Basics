using System;

namespace Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 60/100 не чете парсването на fee1;

            double priceForBagageOver20 = double.Parse(Console.ReadLine());
            double bagageWeigth = double.Parse(Console.ReadLine());
            int daysToTheTravel = int.Parse(Console.ReadLine());
            int countBagages = int.Parse(Console.ReadLine());
            double fee = 0;

            if (bagageWeigth < 10)
            {
                fee += priceForBagageOver20 * 0.2;
            }
            else if (bagageWeigth >= 10 && bagageWeigth <= 20)
            {
                fee += priceForBagageOver20 / 2;
            }
            else if (bagageWeigth > 20)
            {
                double fee1 = double.Parse(Console.ReadLine());
                fee = fee1;
            }

            if (daysToTheTravel > 30)
            {
                fee += fee * 0.1;
            }
            else if (daysToTheTravel >= 7 && daysToTheTravel <= 30)
            {
                fee += fee * 0.15;
            }
            else if (daysToTheTravel < 7)
            {
                fee += fee * 0.4;
            }

            double totalMoney = fee * countBagages;
            Console.WriteLine($"The total price of bags is: {totalMoney:f2} lv. ");
        }
    }
}
