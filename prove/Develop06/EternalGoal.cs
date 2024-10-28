class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"The goal '{_shortName}' has been recorded. {_points} earned.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never completed
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}
