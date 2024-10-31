// Cycling activity
public class Cycling : Activities
{
    private double _speed; // in mph

    public Cycling(DateTime date, int activityLength, double speed) : base(date, activityLength)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (ActivityLength() / 60.0); // miles
    }

    public override double GetSpeed()
    {
        return _speed; // mph
    }

    public override double GetPace()
    {
        return 60.0 / _speed; // min per mile
    }
}