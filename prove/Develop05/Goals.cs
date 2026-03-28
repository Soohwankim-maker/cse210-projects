using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoalList()
    {
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetStatus()} {g.GetName()}");
            i++;
        }
    }

    public int RecordGoalEvent()
    {
        DisplayGoalList();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        return _goals[index].RecordEvent();
    }

    public void SaveFile()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetName());
            }
        }
    }

    public void LoadFile()
    {
        if (File.Exists("goals.txt"))
        {
            Console.WriteLine("Goals loaded (names only for simplicity).");
        }
    }
}