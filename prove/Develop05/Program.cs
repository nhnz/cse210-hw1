using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mindfulness Program");
            Console.WriteLine("Which activity would you like to do?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Please make your choice: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;

                case "2":
                    activity = new ReflectionActivity();
                    break;
            
                case "3":
                    activity = new ListingActivity();
                    break;
            
                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid choice.Try again");
                    ShowSpinner(3);
                    continue;
            }

            activity.Run();
        }
    } 
    
    private static void ShowSpinner(int seconds)
        {
            Console.Write("Pausing");
            for (int i = 0; i < seconds; i++)
                {
                    // Simple animation
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
            Console.WriteLine();
        }
}
