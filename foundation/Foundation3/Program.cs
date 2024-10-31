using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    
    {
        //instances of each activity
        Activities run = new Running(new DateTime(2024, 08, 21), 30, 3.0);
        Activities cycle = new Cycling(new DateTime(2024, 10, 31), 45, 12.0);
        Activities swim = new Swimming(new DateTime(2024, 10, 31), 15, 5);

        // Store activities in a list
        List<Activities> activities = new List<Activities> { run, cycle, swim };


        // Print summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}


    
