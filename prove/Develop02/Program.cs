using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program");

        while (running)
        {
            Console.WriteLine("Create, Display, Save, And Load Journal Entries");
            Console.WriteLine("1. Create Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to file");
            Console.WriteLine("4. Read Journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
