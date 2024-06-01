public class Running : Activity
{
    private double _distance;
    public Running(string date, int mins, double distance) : base(date, mins, "Running")
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return _distance / _mins * 60;
    }

    public override double CalculatePace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _mins / _distance;
    }
}