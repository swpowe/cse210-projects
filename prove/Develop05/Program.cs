using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Load Goals.txt

        // You have 0 points
        // menu 1-6
        bool running = true;

        while (running) MainMenu();


        void MainMenu()
        {
            Console.CursorVisible = true;

            int selection = 0;

            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            bool isInt = int.TryParse(Console.ReadLine(), out selection);

            if (isInt)
            {
                Console.Clear(); // Clear the screen prior to loading requested option
                
                switch (selection) // selection is int
                {
                    case 1:
                        string type = "simple";
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a brief description for your goal? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("How many points are associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());

                        Simple goal = new(type, name, description, points);
                        goal.AddToList(goal); //!! does this work?
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4: // load goals
                        Console.WriteLine("Please enter the full path to the file you'd like to load.");
                        string path = Console.ReadLine();
                        string[] lines = LoadFile(path);
                        string msg = "";

                        if(lines.Length != 0) {
                            msg = "Your file was loaded successfully.";
                        }
                        else {
                            msg = "There was a problem loading your file. Please try again.";
                        }
                        Console.WriteLine(msg);
                        break;
                    case 5: // record event
                        break;
                    case 6: // quit
                        running = false;
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("Goodbye...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid option between 1-6.");
                Thread.Sleep(3000);
                Console.Clear();
            }

        }

        string[] LoadFile(string path){
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                return lines;
            }
            catch (System.Exception)
            {
                return [];
            }
        }
    }
}