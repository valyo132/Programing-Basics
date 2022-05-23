using System;

namespace Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherPrice = int.Parse(Console.ReadLine());
            int bougthTicket = 0, bougthStock = 0;
            int currentStok = 0;
            bool flag = false;

            while (true)
            {
                string stock = Console.ReadLine();
                if (stock == "End")
                {
                    break;
                }
                if (stock.Length > 8)
                {
                    int ticket = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        ticket += stock[i];
                        currentStok = ticket;
                    }
                    if (currentStok > voucherPrice)
                    {
                        flag = true;
                        break;
                    }
                    bougthTicket++;
                    voucherPrice -= ticket;
                }
                else
                {
                    int other = 0;
                    for (int j = 0; j < 1; j++)
                    {
                        other = stock[j];
                        currentStok = other;
                    }
                    if (voucherPrice < 0 || currentStok > voucherPrice)
                    {
                        flag = true;
                        break;
                    }
                    bougthStock++;
                    voucherPrice -= other;
                }
                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine(bougthTicket);
            Console.WriteLine(bougthStock);
        }
    }
}
