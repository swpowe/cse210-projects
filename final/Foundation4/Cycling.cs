public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int mins, int speed) : base(date, mins, "Cycling")
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        //!! Distance (miles) = swimming laps * 50 / 1000 * 0.62
        // Speed (mph or kph) = (distance / minutes) * 60
        return (_speed / 60) * _mins;
    }

    public override double CalculateSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return _speed;
    }

    public override double CalculatePace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _mins / CalculateDistance();
    }
}