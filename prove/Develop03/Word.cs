public class Word {
    private bool _hidden;
    private string _text;

    public Word(string text) {
        _hidden = false;
        _text = text;
    }

    public string GetText() {
        return _text;
    }
}