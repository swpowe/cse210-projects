public class Journal {

    public List<Entry> _entries = new List<Entry>();

    public Journal() {

    }

    public void DisplayJournal() {
        foreach(var entry in _entries) {
            entry.DisplayEntry();
        }
    }


}