class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _keptScore = 0;

    public void Start()
    {
        Console.WriteLine("\nWelcome to Goal Manager. The program will start now.");
        string userInput;
        do
        {   
            // Menu for the user to choose from
            Console.WriteLine("\nChoose an action: ");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            userInput = Console.ReadLine(); //User Input

            //the program to execute based on the user input
            switch (userInput)
            {
                case "1":
                    CreateGoal();  //create a goal
                    break;
                case "2":
                    RecordEvent();  // reacord a goal
                    break;
                case "3":
                    ListGoals();    // list a goals saved
                    break;
                case "4":
                    DisplayPlayerInfo(); // score display
                    break;
                case "5":
                    SaveGoals("goals.txt"); // save a goal
                    break;
                case "6":
                    LoadGoals("goals.txt"); // load goals saved
                    break;
                case "7":
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        } while (userInput != "7");
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_keptScore}");
    }

    private void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type (simple, eternal, checklist): ");
        string type = Console.ReadLine().ToLower();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (type == "checklist")
        {
            Console.WriteLine("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus points for completion: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else if (type == "eternal")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (type == "simple")
        {
            newGoal = new SimpleGoal(name, description, points);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine($"The Goal '{name}' has been added.");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.WriteLine("Enter the index of the goal to record an event for: ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        var goal = _goals[index];
        goal.RecordEvent();

        if (goal.IsComplete())
        {
            _keptScore += goal.GetPoints(); // Points are added when completed.
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_keptScore);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals have been saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Starting with an empty goal list.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            _keptScore = int.Parse(reader.ReadLine());
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(':');
                var goalType = parts[0];
                var details = parts[1].Split(',');

                Goal goal = null;
                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                        if (bool.Parse(details[3])) goal.RecordEvent(); // Mark as complete if applicable
                        break;

                    case "EternalGoal":
                        goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[5]));
                        for (int i = 0; i < int.Parse(details[3]); i++) goal.RecordEvent(); // Simulate completed events
                        break;
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
