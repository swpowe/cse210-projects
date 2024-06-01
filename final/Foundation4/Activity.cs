public abstract class Activity
{
    private string _date;
    protected int _mins;

    private string _type;
    public Activity(string date, int mins, string type)
    {
        _date = date;
        _mins = mins;
        _type = type;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public string DisplayDetails(){
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        // {date} {activity type} {duration} {distance}, {speed mph}, {pace min per mile}
        return $"{_date} {_type} ({_mins} min) - Distance {CalculateDistance().ToString("0.0")}, Speed {CalculateSpeed().ToString("0.0")} mph, Pace: {CalculatePace().ToString("0.0")} min per mile.";
    }




    //      vir The distance
    //      vir The speed(miles per hour or kilometers per hour)
    //      vir The pace(minutes per mile or minutes per kilometer)
    //      A summary in the form of:
    //          03 Nov 2022 Running(30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    //          03 Nov 2022 Running(30 min) : Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km




    // Speed = 60 / pace
    // Pace = 60 / speed
}