// Resume.cs
using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs;

    // Constructor
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Method to add a job
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (var job in _jobs)
        {
            job.DisplayDetails();
        }
    }
}
