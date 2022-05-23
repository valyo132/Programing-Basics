using System;
using System.Text;

namespace Лекция_5_6_Март
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeSwiming = trackLength * timeForOneMeter;
            double timeTimeSlowed = (trackLength / 15) * 12.5;
            double totalTimeSwiming = timeSwiming + timeTimeSlowed;

            if (Math.Floor(totalTimeSwiming) > worldRecord)
            {
                Console.WriteLine($"No, he failed! He was {totalTimeSwiming - worldRecord:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeSwiming:F2} seconds.");
            }
        }
    }
}
