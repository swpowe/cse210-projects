// Receptions, which require people to RSVP, or register, beforehand.
public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        DisplayDetails();
        Console.WriteLine("-------------------------");
        // For receptions this includes an email for RSVP. 
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"To RSVP, please email: {_email}");
        Console.WriteLine("-------------------------");
    }
}