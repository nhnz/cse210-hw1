class BreathingActivity : Activity
{
    public BreathingActivity() : base("The Breathing Activty","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public override void Run()
    {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5); //pause
            Console.WriteLine("Breathe out...");
            ShowCountDown(5); //pause     
        }

        DisplayEndingMessage();
    }
}