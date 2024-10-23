class ReflectionActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    private readonly List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",

    };

    public ReflectionActivity() : base("The Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public override void Run()
    {
        DisplayStartMessage();
        Random random = new Random();
        string prompt = GetRandomPrompt(random);
        Console.WriteLine(prompt);
        ShowSpinner(3); //While the User thinking program pauses

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
            {
                string question = GetRandomQuestion(random);
                Console.WriteLine(question);
                ShowSpinner(10); // Pause for user reflection
            }
            DisplayEndingMessage();
    }

    private string GetRandomPrompt(Random random)
        {
            return _prompts[random.Next(_prompts.Count)];
        }

    private string GetRandomQuestion(Random random)
        {
            return _questions[random.Next(_questions.Count)];
        }

            
    
}
