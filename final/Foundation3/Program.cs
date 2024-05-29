using System;
// Once you have the classes in place, write a program that creates at least one event
// of each type and sets all of their values. Then, for event event, call each of the 
// methods to generate the marketing messages and output their results to the screen.

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();

        Address library = new("123 Smart Street", "Chesterfield", "MO", 63011);
        Address aHall = new("34 West 1200 South", "Provo", "UT", 84604);
        Address lawn = new("1358 North Piper Ln (backyard lawn)", "Orem", "UT", 84103);

        Lecture lecture = new("A Night with Dr. Z", "Join us for an evening of discussion and debate.", "03/10/2024", "1:30pm", library, "Dr. David Zamborsky", 35);
        events.Add(lecture);

        Reception reception = new("Wedding Reception", "Come congratulate the happy couple!", "02/14/2024", "7pm", aHall, "weddingsR-Us@email.com");
        events.Add(reception);

        Outdoor outdoor = new("Sitting under the stars", "The night sky like you've never seen before.", "05/20/2024", "8:30pm", lawn, "Rain is expected so bring a coat!");
        events.Add(outdoor);

        foreach (var e in events)
        {
            Console.WriteLine("_____________________________________________");
            e.DisplayDetails();
            e.DisplayShortDetails();
            e.DisplayFullDetails();
            Console.WriteLine("_____________________________________________");
        }
    }
}