// all events need to have an Event Title, Description, Date, Time, and Address.
// They would like the ability to generate three different messages:

// Full details - Lists all of the above, plus type of event and information specific to that event type. 
// For lectures, this includes the speaker name and capacity. 
// For receptions this includes an email for RSVP. 
// For outdoor gatherings, this includes a statement of the weather.
public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;



    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayDetails()
    {
        // Standard details - Lists the title, description, date, time, and address.
        Console.WriteLine("Details------------------");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date and Time: {_date} @ {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public void DisplayShortDetails()
    {
        // Short description - Lists the type of event, title, and the date.
        Console.WriteLine("Details------------------");
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date and Time: {_date}");
    }

    public abstract void DisplayFullDetails();
}