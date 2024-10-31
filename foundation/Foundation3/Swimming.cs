// Swimming activity
public class Swimming : Activities
{
    private double _distance; // in kilometers

    public Swimming(DateTime date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance; // already in kilometers
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
