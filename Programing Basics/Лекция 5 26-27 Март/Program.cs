using System;

namespace Лекция_5_26_27_Март
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalFreeSpace = length * width * height;
            int takenSpace = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{totalFreeSpace - takenSpace} Cubic meters left.");
                    break;
                }
                int boxes = int.Parse(command);
                takenSpace += boxes;
                if (takenSpace > totalFreeSpace)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeSpace - takenSpace)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
