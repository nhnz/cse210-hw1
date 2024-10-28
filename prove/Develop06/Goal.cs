// Base class for all goals
abstract class Goal
{
    protected string _shortName; // The name of the goal
    protected string _description; // A brief description of a goal
    protected int _points; // Points awarded upon completion

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(); // To be called to record an event associated with the goal
    public abstract bool IsComplete(); // Checks if the goal is complete

    public virtual string GetDetailsString() // Returns a string representation of the goal's status
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation(); // return a string for saving/loading.

     public virtual int GetPoints() // Returns the points awarded upon completion
    {
        return _points;
    }
}
