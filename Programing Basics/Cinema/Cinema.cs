using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int peopleEntered = 0;
            int totalWin = 0;
            int price = 0, price1 = 0;
            int secondCapacity = capacity;
            bool flag = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Movie time!")
                {
                    break;
                }
                int people = int.Parse(input);
                if (people > secondCapacity)
                {
                    flag = true;
                    break;
                }
                if (people % 3 == 0)
                {
                    price += people * 5 - 5;
                }
                else
                {
                    price1 += people * 5;
                }
                peopleEntered += people;
                secondCapacity = secondCapacity - people;

            }
            if (flag)
            {
                Console.WriteLine("The cinema is full.");
                totalWin += price + price1;
                Console.WriteLine($"Cinema income - {totalWin} lv.");
            }
            else
            {
                int seatsLeft = capacity - peopleEntered;
                Console.WriteLine($"There are {seatsLeft} seats left in the cinema.");

                totalWin += price + price1;
                Console.WriteLine($"Cinema income - {totalWin} lv.");
            }
        }
    }
}
