using System;

namespace Тест_Никола
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your wanted results");
            Console.Write("x + y = ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("y + z = ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("x + z = ");
            double a3 = double.Parse(Console.ReadLine());

            double x = ((a1 + a3) - a2) / 2;
            double y = ((a1 + a2) - a3) / 2;
            double z = ((a2 + a3) - a1) / 2;
            Console.WriteLine("------------");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");

            while (true)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1: + ");
                Console.WriteLine("2: - ");
                Console.WriteLine("3: * ");
                Console.WriteLine("4: / ");
                Console.WriteLine("5: Exit ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "+":
                        Console.WriteLine(x + y + z);
                        break;
                    case "-":
                        Console.WriteLine(x - y - z);
                        break;
                    case "*":
                        Console.WriteLine(x * y * z);
                        break;
                    case "/":
                        Console.WriteLine(x / y /z);
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
