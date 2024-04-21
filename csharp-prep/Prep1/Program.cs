using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName, lastName;

        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
        lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}