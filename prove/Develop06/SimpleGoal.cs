class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"The goal '{_shortName}' has been completed and {_points} earned.");
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isCompleted}";
    }
}