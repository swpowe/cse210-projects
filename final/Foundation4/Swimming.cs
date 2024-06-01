public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, int mins, double laps) : base(date, mins, "Swimming")
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return _laps * 50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return CalculateDistance() / _mins * 60;
    }

    public override double CalculatePace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _mins / CalculateDistance();
    }
}