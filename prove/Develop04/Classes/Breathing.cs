using System.Runtime.CompilerServices;

public class Breathing : Mindfulness
{
    // private string _message = "Breathing has started...";
    public Breathing() : base()
    {
        _startingMessage = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.";
    }

    public void BreathingActivity()
    {
        Console.WriteLine($"Breathing activity for {_duration} seconds");
        // Get Ready .... pause
        GetReady();

        // breathe in countdown
        MainBreathingLoop();
        // breathe out countdown
        //


        DisplayEndingMessage("Breathing");
        //!! session end
       
       

    //    DisplaySessionDetails();
    }

    private void MainBreathingLoop()
    {
        // while not hit duration...loop
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;

        // int count = 3; //!! change this to duration evaluation

        while (currentTime < futureTime)
        {
            //!! change all this into a function and make the main while loop part of parent and pass in activity specific
            Console.Write("Breath In...");
            for (int i = 5; i > 0; i--)
            {
                if (currentTime >= futureTime) break;
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                currentTime = DateTime.Now;
            }
            Console.WriteLine();

            Console.Write("Breath Out...");
            for (int i = 5; i > 0; i--)
            {
                if (currentTime >= futureTime) break;
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            // count--;
        }
    }
}