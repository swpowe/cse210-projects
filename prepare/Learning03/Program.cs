using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fOne = new Fraction();
        // Fraction fTwo = new Fraction(6);
        // Fraction fThree = new Fraction(6,7);

        Fraction one = new Fraction();
        Console.WriteLine(one.GetTopNumber());
        Console.WriteLine(one.GetBottomNumber());

        one.SetTopNumber(3);
        one.SetBottomNUmber(4);

        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalFraction());
    }
}