// Lectures, which have a speaker and have a limited capacity.
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {
        DisplayDetails();
        Console.WriteLine("-------------------------");
        // For lectures, this includes the speaker name and capacity. 
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine("-------------------------");
    }
}