using System;

class Program
{
    static void Main(string[] args)
    {
        char gradeLetter;
        int gradeNum;
        decimal gradePercent;
        bool passed;
        
        // Ask the user for grade (as percentage)
        Console.Write("What is your grade as a percent? ");
        gradePercent = Decimal.Parse(Console.ReadLine());
        gradeNum = (int)Decimal.Round(gradePercent, 0);

        // Print the letter grade
        if (gradeNum >= 90) {
            gradeLetter = 'A';
            passed = true;
        }else if (gradeNum >= 80) {
            gradeLetter = 'B';
            passed = true;
        }else if (gradeNum >= 70) {
            gradeLetter = 'C';
            passed = true;
        }else if (gradeNum >= 60) {
            gradeLetter = 'D';
            passed = false;
        }else {
            gradeLetter = 'F';
            passed = false;
        }

        Console.WriteLine($"Your current letter grade is {gradeLetter}.");

        //Display passed if > 70 or failed < 70
        if(passed) {
            Console.WriteLine("Congratulations! You're passing the class! Great Job.");
        }else {
            Console.WriteLine("Unfortunately it looks like you're currently failing. Keep trying!");
        }
    }
}