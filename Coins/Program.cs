using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double coins = change * 100;
            double cents = (int) coins;
            int totalCoins = 0;

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    totalCoins++;
                    cents -= 200;
                }
                else if (cents - 100 >= 0)
                {
                    totalCoins++;
                    cents -= 100;
                }
                else if (cents - 50 >= 0)
                {
                    totalCoins++;
                    cents -= 50;
                }
                else if (cents - 20 >= 0)
                {
                    totalCoins++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    totalCoins++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    totalCoins++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    totalCoins++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    totalCoins++;
                    cents -= 1;
                }
            }
            Console.WriteLine(totalCoins);
        }
    }
}
