using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            string currentBook = Console.ReadLine();

            int checkedBooks = 0;

            while (currentBook != "No More Books")
            {
                if (currentBook == wantedBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    return;
                }
                checkedBooks++;
                currentBook = Console.ReadLine();
            }
            Console.WriteLine($"The book you search is not here!\nYou checked {checkedBooks} books.");
        }
    }
}
