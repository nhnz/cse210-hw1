class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity() : base("The Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public override void Run()
    {
        DisplayStartMessage();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3); // Pause for the user to think

            Console.WriteLine("List as many items as you can before the finishes (type 'done' to finish):");
            int count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "done") break;
                count++;
            }
            Console.WriteLine($"You listed {count} items.");
            DisplayEndingMessage();
        }
}