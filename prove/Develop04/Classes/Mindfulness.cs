public class Mindfulness
{
    protected int _duration; // in seconds
    private int _elapsedTime; // in seconds



    protected string _startingMessage = "test";
    protected string _endingMessage = "test";

    public Mindfulness()
    {
        // _session = new();
    }

    public Mindfulness(int duration, string activity, string description)
    {

    }


    public void DisplayEndingMessage(string activity)
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {activity} Activity.");
    }

    // public void DisplaySessionDetails()
    // {
    //     Console.WriteLine($"Complete Session Log:");
    //     foreach (var item in _session)
    //     {
    //         Console.WriteLine($"Activity: {item.activity} - Duration: {item.duration}");
    //     }
    // }

    public int GetDuration()
    {
        return _duration;
    }

    public void GetReady()
    {
        Console.Write("Get Ready.");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("..");

        }
        Console.Clear();
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine(_startingMessage);

        int durationInt;
        bool isInt = false;

        while (!isInt)
        {
            Console.WriteLine("How long, in seconds, would you like this session to be? ");
            string duration = Console.ReadLine();

            isInt = int.TryParse(duration, out durationInt);

            if (isInt)
            {
                _duration = durationInt;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }

    //!! some shared animation?
    public void Pause()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("..");
        }
    }

}
