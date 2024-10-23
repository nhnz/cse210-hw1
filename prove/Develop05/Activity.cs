// Base class for all activities
using System.Runtime.InteropServices;

abstract class Activity
    {
        protected string _activityName;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _activityName = name;
            _description = description;
        }

        public void DisplayStartMessage()
        {
            Console.Clear();
            Console.WriteLine($"*********{_activityName}**********\n");
            Console.WriteLine(_description + "\n");
            Console.Write("Set the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Prepare to begin");

            ShowSpinner(3); 

        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("You have done a good job!!!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed the {_activityName} and the length of time spent is {_duration} seconds");
            ShowSpinner(5);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i=0; i<seconds; i++)
            {
                //Animation
                Console.Write("-");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }

         protected void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}> ");
                Thread.Sleep(1000); // Wait for 1 second
            }
            
            Console.WriteLine();
        }
        public abstract void Run();
    }
    