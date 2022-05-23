using System;

namespace _8ma_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int prizePerYear = int.Parse(Console.ReadLine());
            double shoes = prizePerYear - prizePerYear * 0.4;
            double suit = shoes - shoes * 0.2;
            double ball = suit / 4; 
            double accsesories = ball / 5; 
            Console.WriteLine(shoes + suit + ball + accsesories + prizePerYear);
        }
    }
}
