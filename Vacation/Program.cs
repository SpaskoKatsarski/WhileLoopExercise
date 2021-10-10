using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoneyForVacation = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int day = 0;
            int spentCounter = 0;

            while (spentCounter != 5)
            {
                string choice = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                day++;

                if (choice == "save")
                {
                    currentMoney += money;
                    spentCounter = 0;
                }
                else if (choice == "spend")
                {
                    spentCounter++;
                    if (money > currentMoney)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= money;
                    }
                }
                if (currentMoney >= neededMoneyForVacation)
                {
                    Console.WriteLine($"You saved the money for {day} days.");
                }
            }
            if (spentCounter == 5)
            {
                Console.WriteLine($"You can't save the money.\n{day}");
            }
        }
    }
}
