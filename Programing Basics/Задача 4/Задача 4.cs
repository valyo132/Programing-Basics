using System;

namespace Задача_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            double totalRakia = 0;
            double totalDegrees = 0;
            int count = 0;

            for (int i = 0; i < days; i++)
            {
                count++;
                double litersRakia = double.Parse(Console.ReadLine());
                totalRakia += litersRakia;
                double degree = double.Parse(Console.ReadLine());
                totalDegrees += litersRakia * degree;
            }
            Console.WriteLine($"Liter: {totalRakia:f2}");
            
            Console.WriteLine($"Degrees: {totalDegrees / totalRakia:f2}");

            if (count == days)
            {
                double avarage = totalDegrees / totalRakia;
                if (avarage <= 38)
                {
                    Console.WriteLine("Not good, you should baking!");
                }
                else if (avarage > 38 && avarage < 42)
                {
                    Console.WriteLine("Super!");
                }
                else if (avarage >= 42)
                {
                    Console.WriteLine("Dilution with distilled water!");
                }
            }
        }
    }
}
