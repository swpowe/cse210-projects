public class List : Mindfulness
{
    private List<string> _prompts;
    private List<string> _userList;
    public List()
    {
        _startingMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
        _userList = new();
    }

    public void ListActivity()
    {
        Console.WriteLine($"Listing activity for {_duration} seconds");
        GetReady();

        MainListLoop();

        DisplayEndingMessage("List");
    }

    public void MainListLoop()
    {
        // random prompt
        // countdown to get ready
        // input loop until out of time





        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetItem(_prompts)} ---");
        Console.Write("You may begin in ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;

        // Console.Clear();
        Console.WriteLine();
        while (currentTime < futureTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            _userList.Add(input);
            currentTime = DateTime.Now;
            // Console.Write(GetItem(_questions));
            // for (int i = 0; i < 15; i++)
            // {
            //     Console.Write(".");
            //     Thread.Sleep(500);
            //     Console.Write("\b \b \b");
            //     Console.Write("..");
            //     Thread.Sleep(500);
            //     Console.Write("\b \b \b");
            //     currentTime = DateTime.Now;
            // }
            // Console.WriteLine();
        }

    Console.WriteLine($"Length: {_userList.Count}");

    }

    string GetItem(List<string> list)
    {
        Random rand = new();
        string item = list[rand.Next(list.Count - 1)];
        return item;
    }
}