using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int face = width * lenght;
            int totalTakenPieces = 0;

            string input = Console.ReadLine();
            while (input != "STOP")
            {
                int piecesOfCake = int.Parse(input);
                totalTakenPieces += piecesOfCake;

                if (totalTakenPieces > face)
                {
                    int neededPieces = totalTakenPieces - face;
                    Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
                    return;
                }

                input = Console.ReadLine();
            }
            int piecesLeft = face - totalTakenPieces;
            Console.WriteLine($"{piecesLeft} pieces are left.");
        }
    }
}
