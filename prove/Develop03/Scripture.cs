public class Scripture {
    private Reference _reference;
    private List<Word> _words;
    // scripture has reference and list of words that make up the scripture
    // on instantiation constructor creates default scriptures? 

    public Scripture(List<Word> words) {
        _words = words;
    }

    public List<Word> GetWords() {
        return _words;
    }

    public void SetReference(Reference reference){
        _reference = reference;
    }

    public Reference GetReference(){
        return _reference;
    }
}