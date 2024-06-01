using System;
// Once you have the classes in place, write a program that creates at least one activity of each type. Put each of these activities in the same list. Then iterate through this list and call the GetSummary method on each item and display the results.
class Program
{
    static void Main(string[] args)
    {
        Tracker tracker = new();

        Running run = new("03 Nov 2022", 30, 3.0);

        Cycling cycle = new("04 Nov 2022", 30, 15);

        Swimming swim = new("05 Nov 2022", 35, 32.2);

        tracker.AddActivity(run);
        tracker.AddActivity(cycle);
        tracker.AddActivity(swim);
        

        foreach (var item in tracker.GetActivities())
        {
            Console.WriteLine(item.DisplayDetails());
        }
    }
}