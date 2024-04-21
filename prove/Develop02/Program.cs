using System;
using System.IO;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        string filename;
        string[] lines;

        // Get the filename from the user
        Console.Write("Please enter a filename: ");
        filename = Console.ReadLine();

        // Append to file
        using (StreamWriter outputFile = new StreamWriter(filename, append: true)) {
            string color = "Blue";
            string prompt = "What's your favorite color?";
            outputFile.WriteLine("This is the first line in the file...5");
            outputFile.WriteLine($"This is the second line in the file...5{color}|{prompt}|{DateTime.Now}");
        }

        // Read Lines from file
        lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string response, prompt;
            string[] parts = line.Split("|");
            DateTime date = DateTime.MinValue;

            if(line.Contains("|")) {
                response = parts[0];
                prompt = parts[1];

                if(parts.Length >= 3){
                    date = DateTime.Parse(parts[2]);
                }
            }else {
                response = line;
                prompt = "...";
            }

            Console.WriteLine($"Prompt: {prompt}.");
            Console.WriteLine($"Response: {response}.");
            Console.WriteLine($"Date: {date}.");
            Console.WriteLine();
            
            // Console.WriteLine(line);
        }
    }
}