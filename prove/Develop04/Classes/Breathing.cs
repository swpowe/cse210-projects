public class Breathing : Mindfulness
{
    // private string _message = "Breathing has started...";
    public Breathing()
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

        DisplayEndingMessage();
    }

    private void MainBreathingLoop()
    {
        // while not hit duration...loop
        int count = 3; //!! change this to duration evaluation
        while (count <= 10 && count != 0)
        {
            Console.Write("Breath In...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            Console.Write("Breath Out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            count--;
        }
    }

}