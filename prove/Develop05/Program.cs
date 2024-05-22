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
        List<Goal> list = new();
        int totalPoints = 0; //!! Is this the best place for this?

        while (running) MainMenu();

        void MainMenu()
        {
            Console.CursorVisible = true;

            int selection = 0;

            Console.WriteLine("----------------------");
            Console.WriteLine($"Total Points {totalPoints}");
            Console.WriteLine("----------------------");


            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            bool isInt = int.TryParse(Console.ReadLine(), out selection);

            if (isInt)
            {
                Console.Clear(); // Clear the screen prior to loading requested option

                switch (selection) // selection is int
                {
                    case 1:
                        string type = ""; //!! need to modify this based on their choice in 2nd menu
                        string name = "";
                        string description = "";
                        int points = 0;

                        // Sub Menu
                        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n  4. Return to Main Menu");
                        bool subIsInt = int.TryParse(Console.ReadLine(), out selection);

                        while (!subIsInt || (selection <= 0 || selection >= 5))
                        {
                            Console.WriteLine("Please enter a valid number between 1 and 4");
                            subIsInt = int.TryParse(Console.ReadLine(), out selection);
                        }

                        switch (selection)
                        {
                            case 1: // simple
                                type = "Simple";
                                //!! turn this into a function with overloads maybe?
                                Console.WriteLine("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a brief description for your goal? ");
                                description = Console.ReadLine();
                                Console.WriteLine("How many points are associated with this goal? ");
                                points = int.Parse(Console.ReadLine());

                                Goal simple = new(type, name, description, points);
                                list.Add(simple);

                                break;
                            case 2: // eternal
                                type = "Eternal";
                                Console.WriteLine("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a brief description for your goal? ");
                                description = Console.ReadLine();
                                Console.WriteLine("How many points are associated with this goal? ");
                                points = int.Parse(Console.ReadLine());

                                Goal eternal = new(type, name, description, points);
                                list.Add(eternal);

                                break;
                            case 3: // checklist
                                type = "Checklist";
                                Console.WriteLine("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a brief description for your goal? ");
                                description = Console.ReadLine();
                                Console.WriteLine("How many points are associated with this goal? ");
                                points = int.Parse(Console.ReadLine());

                                Console.WriteLine("How many times does your goal have to be accomplished to get a bonus? ");
                                int bonusTimes = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                                int bonusPoints = int.Parse(Console.ReadLine());

                                Checklist checklist = new(type, name, description, points, bonusTimes, bonusPoints);
                                list.Add(checklist);

                                break;
                            case 4: // return to main menu
                                break;
                            default:

                                break;
                        }

                        break;
                    case 2: // list goals
                        ListGoals();
                        Console.WriteLine("Hit any key to return to the Main Menu.");
                        Console.ReadLine();
                        break;
                    case 3: // save goals
                        // write total points on first line
                        // then every line after to the file
                        Console.WriteLine("What is the filename for your goals file?");
                        string fileName = Console.ReadLine();
                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
                            // You can add text to the file with the WriteLine method
                            outputFile.WriteLine(totalPoints);

                            foreach (var i in list)
                            {
                                outputFile.WriteLine(i.GetGoalDetails());
                            }
                        }
                        break;
                    case 4: // load goals
                        list.Clear(); // clear current list
                        Console.WriteLine("Please enter the full path to the file you'd like to load.");
                        string path = Console.ReadLine();
                        string[] lines = LoadFile(path);
                        string msg = "";

                        if (lines.Length != 0)
                        {
                            for (int i = 0; i < lines.Length; i++)
                            {
                                if (i == 0)
                                {
                                    totalPoints = int.Parse(lines[i]);
                                    continue;
                                }
                                else
                                {
                                    string[] values = lines[i].Split("|");

                                    // Goal g = new(values[0], values[1], values[2], int.Parse(values[3])); //!! Have to figure out how to overload this Do I have to know the type?
                                    // list.Add(g);
                                    string goalType = values[0];

                                    switch (goalType)
                                    {
                                        case "Simple":
                                            Simple s = new(values[0], values[1], values[2], int.Parse(values[3]));
                                            list.Add(s);
                                            break;
                                        case "Eternal":
                                            Eternal e = new(values[0], values[1], values[2], int.Parse(values[3]));
                                            list.Add(e);
                                            break;
                                        case "Checklist":
                                            Checklist c = new(values[0], values[1], values[2], int.Parse(values[3]), 3, 4); //!! change ints
                                            list.Add(c);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            msg = "Your file was loaded successfully.";
                        }
                        else
                        {
                            msg = "There was a problem loading your file. Please try again.";
                        }
                        Console.WriteLine(msg);
                        break;
                    case 5: // record event
                        // list goals
                        ListGoals();
                        // which goal did you accomplish
                        Console.WriteLine("Which goal did you accomplish?");
                        int choice = int.Parse(Console.ReadLine());
                        Goal item = list[choice - 1];

                        if (item.GetGoalType() == "Eternal")
                        {
                            Console.WriteLine("Eternal goals aren't complete in this life but we'll give you points anyways. ;)");
                        }
                        
                        item.MarkCompleted(); //!! what about Eternal Goals

                        // if (item.GetGoalType() == "Checklist")
                        // {
                        //     if(item.GetBonusPoints())
                        //     Console.WriteLine("Eternal goals aren't complete in this life but we'll give you points anyways. ;)");
                        // }

                        // congrats you earned __ points
                        totalPoints += item.GetPoints();
                        Console.WriteLine($"Congratulations! You earned {item.GetPoints()}!");
                        Thread.Sleep(3000); //!! Reward Animation?
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

        string[] LoadFile(string path)
        {
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

        void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("Here are your goals:");
            Console.WriteLine("--------------------");
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{i + 1} ");
                    list[i].DisplayGoal();
                }
            }
            else
            {
                Console.WriteLine("No Goals Yet! Set Some!");
            }

            Console.WriteLine("--------------------");
        }
    }


}