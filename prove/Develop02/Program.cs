// I messed around with formatting a bit, added some additional prompts.
// Investigated JSON a bit. 
// Used some functions
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        // display menu asking for user input 1 - 5
        string menu = @"Please select one of the following options:
        1. Write a journal entry
        2. Display all journal entries
        3. Save the current journal to a file
        4. Load a journal from a file
        5. Add a new prompt
        6. Exit
        ";
        

        List<string> prompts = new List<string>();
        prompts.Add("What is something meaningful that happened to you today?");
        prompts.Add("What was the best thing that happened today?");
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What's something you hope to do better tomorrow?");
        prompts.Add("What did you do to serve others today?");

        Journal currentJournal = new Journal();

        while (running)
        {
            Console.WriteLine(menu);
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Random random = new Random();
                    int promptIndex = random.Next(0, prompts.Count);
                    Console.WriteLine(prompts[promptIndex]);
                    Console.Write(">");
                    Entry newEntry = new Entry();
                    string entry = Console.ReadLine();

                    // create journal
                    // save
                    newEntry.CreateEntry(prompts[promptIndex], DateAndTime.Now, entry);
                    currentJournal._entries.Add(newEntry);

                    // selection = 0; // shouldn't exit do this better.
                    break;
                case 2:
                    currentJournal.DisplayJournal();
                    // selection = 0; // shouldn't exit do this better.
                    break;
                case 3:
                    Console.WriteLine("Three");
                    SaveJournal(currentJournal);
                    // selection = 0; // shouldn't exit do this better.
                    break;
                case 4:
                    Console.WriteLine("Four");
                    LoadJournal();
                    // selection = 0; // shouldn't exit do this better.
                    break;
                case 5:
                    Console.WriteLine("Enter your prompt:");
                    string newPrompt = Console.ReadLine();
                    Console.WriteLine("Enter the category:");
                    prompts.Add(newPrompt);
                    break;
                case 6:
                    running = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number. 5 to Exit");
                    break;
            }
        }
        void SaveJournal(Journal currentJournal)
        {
            // // Get the filename from the user
            Console.Write("Please enter a filename: ");
            string filename = Console.ReadLine();

            // // Append to file
            using (StreamWriter outputFile = new StreamWriter(filename, append: false))
            {
                foreach (var entry in currentJournal._entries)
                {
                    outputFile.WriteLine($"{entry._timestamp}|{entry._prompt}|{entry._entry}");
                }

            }
        }

        void LoadJournal()
        {
            Console.WriteLine("Please enter the filename of the file you'd like to load.");
            Console.Write(">");
            string filename = Console.ReadLine();

            // read lines from file into
            string[] lines = System.IO.File.ReadAllLines(filename);
            currentJournal._entries.Clear();
            foreach (string line in lines)
            {
                // string prompt, entry;
                string[] parts = line.Split("|");
                // DateTime date = DateTime.MinValue;

                if(line.Contains("|")) {
                    // clear currentJournal
                    
                    Entry newEntry = new Entry();

                    newEntry._timestamp = DateTime.Parse(parts[0]);
                    newEntry._prompt = parts[1];
                    newEntry._entry = parts[2];

                    currentJournal._entries.Add(newEntry);

                }else {
                    Console.WriteLine("There was an error loading the file.");
                }
            }
        }
    }


}


// currently if you write to the same file, it appends the entire journal to that file.
// so when I loaded first_test then added a new entry, it duplicated the original entries.
