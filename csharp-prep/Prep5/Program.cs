using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int favNumber;
        int sqNumber;

        DisplayMessage();
        name = PromptUserName();
        favNumber = PromptUserNumber();
        sqNumber = SquareNumber(favNumber);
        DisplayResult(name, sqNumber);
    }

    static void DisplayMessage() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        
        return number;
    }

    static int SquareNumber(int num) {
        int sqNumber = num * num;
        
        return sqNumber;
    }

    static void DisplayResult(string name, int num) {
        Console.WriteLine($"{name}, the square of your number is {num}.");
    }
}