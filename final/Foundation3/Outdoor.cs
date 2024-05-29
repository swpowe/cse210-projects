// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
public class Outdoor : Event
{
    private string _weatherForecast;
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _type = "Outdoor";
        _weatherForecast = weather;
    }

    public override void DisplayFullDetails()
    {
        DisplayDetails();
        Console.WriteLine("-------------------------");
        // For outdoor gatherings, this includes a statement of the weather.
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine(_weatherForecast);
        Console.WriteLine("-------------------------");
    }
}