using System;

namespace Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double secondBuget = buget;
            double totalMoneyForActors = 0;
            double moneyLeft = 0;
            double secondSalary = 0;
            double totalOfSecondSalary = 0;

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "ACTION")
                {
                    moneyLeft += buget - totalMoneyForActors;
                    Console.WriteLine($"We are left with {moneyLeft:f2} leva.");
                    break;
                }
                if (name.Length > 15)
                {
                    secondSalary = secondBuget * 0.2;
                    totalOfSecondSalary += secondSalary; 
                    totalMoneyForActors += secondSalary;
                    if (secondSalary > secondBuget)
                    {
                        double moneyNeeded = Math.Abs(totalMoneyForActors - buget);
                        Console.WriteLine($"We need {moneyNeeded:f2} leva for our actors.");
                        break;
                    }
                    secondBuget = secondBuget - secondSalary;
                    continue;
                }
                string input = Console.ReadLine();
                if (input == "ACTION")
                {
                    moneyLeft += buget - totalMoneyForActors;
                    Console.WriteLine($"We are left with {moneyLeft:f2} leva.");
                    break;
                }
                double salary = double.Parse(input);
                totalMoneyForActors += salary;
                if (salary > secondBuget)
                {
                    double moneyNeeded = Math.Abs(totalMoneyForActors - buget);
                    Console.WriteLine($"We need {moneyNeeded:f2} leva for our actors.");
                    break;
                }
                secondBuget = secondBuget - salary;
            }
        }
    }
}
