public class Entry {

    public string _prompt = "";
    public string _entry = "";
    public DateTime _timestamp;

    public Entry() {

    }

    // create entry
    // prompt index, date, string
    public void CreateEntry(string prompt, DateTime timestamp, string entry) {
        // store in the Journal Entries list
        _timestamp = timestamp;
        _prompt = prompt;
        _entry = entry;
    }

    public void DisplayEntry() {
        Console.WriteLine($"Date: {_timestamp}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();
    }
}