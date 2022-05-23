using System;

namespace _9ta_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double prosentegesTakenSpace = double.Parse(Console.ReadLine());

            double v = length * width * heigth;
            double SpaceInLiters = v * 0.001;
            double neddedLiters = SpaceInLiters * (1 - (prosentegesTakenSpace / 100));

            Console.WriteLine(neddedLiters);
        }
    }
}
