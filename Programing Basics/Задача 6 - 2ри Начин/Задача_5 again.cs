using System;

namespace Задача_6___2ри_Начин
{
    internal class Задача_5___2ри_Начин
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string SecondI = i.ToString();
                bool special = true;

                for (int j = 0; j < SecondI.Length; j++)
                {
                    char digit = SecondI[j];
                    int currentDigit = int.Parse(SecondI.ToString());
                    if (currentDigit == 0 || n % currentDigit != 0)
                    {
                        special = false;
                        break;
                    }
                }
                if (special)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
