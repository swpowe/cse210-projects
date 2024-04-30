public class Fraction{
    private int _topNumber;
    private int _bottomNumber;
    public Fraction(){
        _topNumber = 1;
        _bottomNumber = 1;
        Console.WriteLine($"{_topNumber} / {_bottomNumber}");
    }

    public Fraction(int topNumber){
        _topNumber = topNumber;
        _bottomNumber = 1;
        Console.WriteLine($"{_topNumber} / {_bottomNumber}");                    
    }

    public Fraction(int topNumber, int bottomNumber){
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
        Console.WriteLine($"{_topNumber} / {_bottomNumber}");
    }

    public int GetTopNumber(){
        return _topNumber;
    }

    public int GetBottomNumber(){
        return _bottomNumber;
    }

    public void SetTopNumber(int topNumber){
        _topNumber = topNumber;
    }

    public void SetBottomNUmber(int bottomNumber){
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString() {
        // could have done
        // string text = ${_topNumber} / {_bottomNumber};
        string completeFraction = _topNumber + "/" + _bottomNumber;
        return completeFraction;
    }

    public double GetDecimalFraction() {
        // could have done 
        // return (double)_topNumber / (double)_bottomNumber;
        double doubleFraction = Convert.ToDouble(_topNumber) / Convert.ToDouble(_bottomNumber);
        return doubleFraction;
    }


}