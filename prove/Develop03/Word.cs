public class Word {
    private bool _hidden;
    private string _text;

    public Word() {

    }

    public Word(string text) {
        _hidden = false;
        _text = text;
    }

    public string GetText() {
        return _text;
    }

    public bool GetHidden(){
        return _hidden;
    }

    public void SetHidden(bool hidden){ // does this need to take a bool? Reset all back to defaults?
        _hidden = hidden;
    }
}