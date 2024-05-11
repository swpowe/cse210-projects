public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // constructor if no end version, then single verse

    public Reference(string fullReference)
    {
        string[] userReference = fullReference.Split(",");

        _book = userReference[0];
        _chapter = Int32.Parse(userReference[1]);
        _startVerse = Int32.Parse(userReference[2]);
        _endVerse = Int32.Parse(userReference[3]);

    }
    public Reference(string book, int chapter, int startingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startingVerse;
        _endVerse = startingVerse;
    }

    public Reference(string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startingVerse;
        _endVerse = endingVerse;
    }

    

    // public string GetReference() // do I need this?
    // {
    //     if (_startVerse == _endVerse)
    //     {
    //         return $"{_book} {_chapter}:{_startVerse}";
    //     }
    //     else
    //     {
    //         return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    //     }
    // }

    public void DisplayReference()
    {
        if (_startVerse == _endVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }

    // public Reference AddReference(string fullReference)
    // {
    //     string[] userReference = fullReference.Split(",");

    //     string book = userReference[0];
    //     int chapter = Int32.Parse(userReference[1]);
    //     int startVerse = Int32.Parse(userReference[2]);
    //     int endVerse = Int32.Parse(userReference[3]);

    //     Reference addReference = new Reference(book, chapter, startVerse, endVerse);

    //     return addReference;
    // }

}