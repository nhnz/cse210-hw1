// Running activity
public class Running : Activities
{
    private double _distance; // in kilometers

    public Running(DateTime date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / (ActivityLength() / 60.0)); // km/h
    }

    public override double GetPace()
    {
        return ActivityLength() / _distance; // min per km
    }
}

