using System;
using System.IO;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // string filename;
        // string[] lines;

        // // Get the filename from the user
        // Console.Write("Please enter a filename: ");
        // filename = Console.ReadLine();

        // // Append to file
        // using (StreamWriter outputFile = new StreamWriter(filename, append: true)) {
        //     string color = "Blue";
        //     string prompt = "What's your favorite color?";
        //     outputFile.WriteLine("This is the first line in the file...5");
        //     outputFile.WriteLine($"This is the second line in the file...5{color}|{prompt}|{DateTime.Now}");
        // }

        // // Read Lines from file
        // lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string response, prompt;
        //     string[] parts = line.Split("|");
        //     DateTime date = DateTime.MinValue;

        //     if(line.Contains("|")) {
        //         response = parts[0];
        //         prompt = parts[1];

        //         if(parts.Length >= 3){
        //             date = DateTime.Parse(parts[2]);
        //         }
        //     }else {
        //         response = line;
        //         prompt = "...";
        //     }

        //     Console.WriteLine($"Prompt: {prompt}.");
        //     Console.WriteLine($"Response: {response}.");
        //     Console.WriteLine($"Date: {date}.");
        //     Console.WriteLine();

        //     // Console.WriteLine(line);
        // }

        // display menu asking for user input 1 - 5
        string menu = @"Please select one of the following options:
        1. Write a journal entry
        2. Display all journal entries
        3. Save the current journal to a file
        4. Load a journal from a file
        5. Add a new prompt
        6. Exit
        ";
        int selection = 0;

        // Prompts prompts = new Prompts();

        List<string> prompts = new List<string>();
        prompts.Add("What is something meaningful that happened to you today?");
        prompts.Add("What was the best thing that happened today?");
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        while (selection == 0)
        {
            Console.WriteLine(menu);
            selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Random random = new Random();
                    int promptIndex = random.Next(0, prompts.Count);
                    Console.WriteLine(prompts[promptIndex]);
                    string entry = Console.ReadLine();
                    Entry newEntry = new Entry();
                    Console.WriteLine(newEntry.CreateEntry(1, DateAndTime.Now, entry));
                    selection = 0;
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    // Prompt newPrompt = new Prompt();
                    Console.WriteLine("Enter your prompt:");
                    string newPrompt = Console.ReadLine();
                    Console.WriteLine("Enter the category:");
                    // newPrompt._category = Console.ReadLine();
                    prompts.Add(newPrompt);
                    selection = 0;
                    break;
                case 6:
                    Console.WriteLine("Six");
                    selection = 1;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number. 5 to Exit"); // string not in correct format issue
                    break;
            }
        }
    }
}