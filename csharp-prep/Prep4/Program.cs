using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list
        List<int> numbers = new List<int>();
        bool running = true;
        // Ask the user for a number, 0 to end
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        // while input number 0?
        while(running) {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            if(number == 0) running = false; 
        }
        
        // display sum, average, highest
        // I could have done a foreach but thought I'd use the built in methods instead.
        Console.WriteLine($"The sum is: {numbers.Sum()}.");
        Console.WriteLine($"The average is {numbers.Average()}.");
        Console.WriteLine($"The average is {numbers.Max()}.");
    }
}