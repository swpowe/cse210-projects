public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse; // start verse and end verse?
    private int _endVerse;

    // constructor if no end version, then single verse
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

    public string GetReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

}