public class Listening : Mindfulness
{

    public Listening()
    {

    }

    public void ListeningActivity()
    {
        Console.WriteLine($"Reflection activity for {_duration} seconds");
        GetReady();

        MainListeningLoop();

        DisplayEndingMessage("Listening");
    }

    public void MainListeningLoop()
    {


    }
}