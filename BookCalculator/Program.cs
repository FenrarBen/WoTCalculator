using System;
using System.Collections.Generic;

namespace BookCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            int month = date.Month;
            int day = date.Day;
            int days = 0;

            for (int i = 1; i < month; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10)
                {
                    days += 31;
                }

                if (i == 2)
                {
                    days += 28;
                }

                if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    days += 30;
                }
            }

            days += day;

            int count = 0;
            while (days >= 20)
            {
                count++;
                days -= 20;
            }

            List<string> books = new List<string>();
            books.Add("New Spring");
            books.Add("The Eye of the World");
            books.Add("The Great Hunt");
            books.Add("The Dragon Reborn");
            books.Add("The Shadow Rising");
            books.Add("The Fires of Heaven");
            books.Add("Lord of Chaos");
            books.Add("A Crown of Swords");
            books.Add("The Path of Daggers");
            books.Add("Winter's Heart");
            books.Add("Crossroads of Twilight");
            books.Add("Knife of Dreams");
            books.Add("The Gathering Storm");
            books.Add("Towers of Midnight");
            books.Add("A Memory of Light");

            Console.WriteLine("Today is " + date.ToString("D"));

            if (count < 15)
            {
                Console.WriteLine($"You should be {days * 5}% finished with {books[count]}");
            }
            else
            {
                Console.WriteLine("You should be finished with the entire series");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();

        }
    }
}
