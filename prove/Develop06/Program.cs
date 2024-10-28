using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.LoadGoals("goals.txt"); // Load existing goals if they exist
        goalManager.Start(); // Start main program
    }
}

    
