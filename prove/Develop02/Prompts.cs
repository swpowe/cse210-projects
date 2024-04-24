public class Prompts {

    public List<Prompt> _prompts = new List<Prompt>();

    public Prompts() {
        Prompt p1 = new Prompt();
        p1._prompt = "What was the best thing that happened today?";
        p1._category = "Generic";

        Prompt p2 = new Prompt();
        p2._prompt = "Who was the most interesting person I interacted with today?";
        p2._category = "Generic";

        Prompt p3 = new Prompt();
        p3._prompt = "How did I see the hand of the Lord in my life today?";
        p3._category = "Generic";

        Prompt p4 = new Prompt();
        p4._prompt = "What was the strongest emotion I felt today?";
        p4._category = "Generic";

        Prompt p5 = new Prompt();
        p5._prompt = "If I had one thing I could do over today, what would it be?";
        p5._category = "Generic";
        
        _prompts.Add(p1);
        _prompts.Add(p2);
        _prompts.Add(p3);
        _prompts.Add(p4);
        _prompts.Add(p5);

        Console.Write(_prompts.Count());
    }

}