using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        int score = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    goals.AddGoal(CreateGoal());
                    break;
                case 2:
                    goals.DisplayGoalList();
                    break;
                case 3:
                    score += goals.RecordGoalEvent();
                    break;
                case 4:
                    goals.SaveFile();
                    break;
                case 5:
                    goals.LoadFile();
                    break;
                case 6:
                    running = false;
                    break;
            }
        }
    }

    static Goal CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            return new SimpleGoal(name, desc, points);
        }
        else if (type == 2)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            return new ChecklistGoal(name, desc, points, target, bonus);
        }
        else
        {
            return new EternalGoal(name, desc, points);
        }
    }
}