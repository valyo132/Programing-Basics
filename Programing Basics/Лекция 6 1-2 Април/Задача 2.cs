using System;

namespace Задача_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string current = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < current.Length; j++)
                {
                    int digit = int.Parse(current[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

