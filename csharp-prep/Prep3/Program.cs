using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessedNumber;
        int count = 0;

        bool guessed = false;

        // Ask user for a magic number
        // Console.Write("What's the magic number (between 1-100)");
        // magicNumber = int.Parse(Console.ReadLine());

        // Tell user higher / lower or guessed
        while(!guessed) {
            Console.Write("What's your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            count++;
        
            if(guessedNumber == magicNumber) {
                Console.WriteLine("Great job!");
                Console.WriteLine($"It only took you {count} guesses!");
                guessed = true;
            }else if(guessedNumber > magicNumber) {
                Console.WriteLine("Lower");
            }else {
                Console.WriteLine("Higher");
            }
        }
        // Loop until guessed
        // Random number between 1 - 100 instead of user
    }
}