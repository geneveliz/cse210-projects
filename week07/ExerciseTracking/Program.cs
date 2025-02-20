//Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 12.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 40)
        };

        // Iterate through the list and display
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
