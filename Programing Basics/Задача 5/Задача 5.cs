using System;

namespace Задача_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startMeters = 5364;
            int goalMeters = 8848;
            int days = 1;

            while (true)
            {
                if (days > 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(startMeters);
                    break;
                }
                string command = Console.ReadLine();
                if (command == "END")
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(startMeters);
                    break;
                }
                if (command == "Yes")
                {
                    days++;
                    if (days > 5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine(startMeters);
                        break;
                    }
                }
                int meters = int.Parse(Console.ReadLine());
                startMeters += meters;

                if (startMeters >= goalMeters)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }
            }
        }
    }
}
