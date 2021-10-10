using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;
            int totalBoxes = 0;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                totalBoxes += boxes;
                if (totalBoxes > volume)
                {
                    int neededSpace = totalBoxes - volume;
                    Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                int freeSpace = volume - totalBoxes;
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
