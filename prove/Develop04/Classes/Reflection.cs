using System.Security.Cryptography;

public class Reflection : Mindfulness
{
    private List<string> _prompts;
    private List<string> _questions;
    public Reflection()
    {
        _startingMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];

        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        ];


    }

    public void ReflectionActivity()
    {
        Console.WriteLine($"Reflection activity for {_duration} seconds");
        GetReady();

        MainReflectionLoop();

        DisplayEndingMessage("Reflection");
    }

    string GetItem(List<string> list)
    {
        Random rand = new();
        string item = list[rand.Next(list.Count - 1)];
        return item;
    }

    private void MainReflectionLoop()
    {

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetItem(_prompts)} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
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

        Console.Clear();
        while (currentTime < futureTime)
        {
            Console.Write(GetItem(_questions));
            for (int i = 0; i < 15; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write("\b \b \b");
                Console.Write("..");
                Thread.Sleep(500);
                Console.Write("\b \b \b");
                currentTime = DateTime.Now;
            }
            Console.WriteLine();
        }
    }
}