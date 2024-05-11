using System;
// Inheritance Learning Activity
class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment1 = new("Spencer Powell", "Math Stuff");

        // Console.WriteLine(assignment1.GetSummary());

        // Math math1 = new("Spencer Powell", "Fractions", "7.3", "8-19");

        // Console.WriteLine(math1.GetSummary());
        // Console.WriteLine(math1.GetHomeworkList());

        Writing writing1 = new("Spencer Powell", "European History", "The Cause of WWII");

        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}