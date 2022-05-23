using System;

namespace Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            string winner = "";
            bool hattrick = false;

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());

                if (goals > max)
                {
                    max = goals;
                    winner = name;
                    if (goals >= 3)
                    {
                        hattrick = true;
                    }
                }
                if (goals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{winner} is the best player!");
            if (hattrick)
            {
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {max} goals.");
            }
        }
    }
}
