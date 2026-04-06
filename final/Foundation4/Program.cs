using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("April 3", 30, 3.0));
        activities.Add(new Cycling("April 3", 45, 12.0));
        activities.Add(new Swimming("April 3", 20, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}