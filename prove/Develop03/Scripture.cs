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

    public void DisplayScripture(){
        Console.WriteLine("---------------");
        _reference.DisplayReference();

        // hidden vs not
        foreach (var word in _words)
        {
            if(word.GetHidden()){
                foreach (var letter in word.GetText())
                {
                    Console.Write($"_");
                }
                Console.Write(" ");
            }else{
                Console.Write($"{word.GetText()} ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("---------------");
    }

    // public Scripture GetScripture(){

    //     return Scripture
    // }
    public void ShowAll(){
        foreach (var word in _words)
        {
            word.SetHidden(false);
        }
    }
}


// John 3:16
// For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting ilife.

// Proverbs 3:5-6
// Trust in the Lord with all thine heart; and lean not unto thine own understanding.

// In all thy ways acknowledge him, and he shall direct thy paths.