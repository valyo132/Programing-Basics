using System;

namespace The_Most_Powerful_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int sum = 0;
            string winner = "";

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "End of words")
                {
                    break;
                }
                for (int i = 0; i < word.Length; i++)
                {
                    sum += word[i];
                }
                if (word[0] == 'а' || word[0] == 'A' || word[0] == 'e' || word[0] == 'E' || word[0] == 'i' || word[0] == 'I' || word[0] == 'o'
                || word[0] == 'O' || word[0] == 'u' || word[0] == 'U' || word[0] == 'y' || word[0] == 'Y')
                {
                    sum *= Math.Abs(word.Length);
                }
                else
                {
                    sum /= Math.Abs(word.Length);
                }
                if (sum > max)
                {
                    max = sum;
                    winner = word;
                }
                sum = 0;
            }
            Console.WriteLine($"The most powerful word is {winner} - {max}");
        }
    }
}
