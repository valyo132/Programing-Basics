using System;

namespace Лекция_4___19_20_Март
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            byte people = byte.Parse(Console.ReadLine());
            double totalPoints = 0;

            for (int i = 1; i <= people; i++)
            {
                string judges = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                totalPoints += pointsFromAcademy + ((judges.Length * judgePoints)) / 2;
                pointsFromAcademy = 0;
                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {totalPoints:F1}!");
                    //i = people + 1;
                    break;
                }
            }
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorsName} you need {1250.5 - totalPoints:F1} more!");
            }
        }
    }
}
