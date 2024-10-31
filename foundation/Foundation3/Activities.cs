// Base class for all activities
public class Activities
{
    private DateTime _date;
    protected int _activityLength;

    public Activities(DateTime date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} - Length: {_activityLength} min, Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }

    protected int ActivityLength()
    {
        return _activityLength;
    }
}
