using System;

namespace Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double feeEntry = double.Parse(Console.ReadLine());
            double shezlong = double.Parse(Console.ReadLine());
            double chadur = double.Parse(Console.ReadLine());

            double totalChaduri = Math.Ceiling(countPeople * 0.5) * chadur;
            double totalShezlongi = Math.Ceiling(countPeople * 0.75) * shezlong;
            double totalEntyMoney = countPeople * feeEntry;

            double totalMoney = totalChaduri + totalEntyMoney + totalShezlongi;
            Console.WriteLine($"{totalMoney:f2} lv.");
        }
    }
}
