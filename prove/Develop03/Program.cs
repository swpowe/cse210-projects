using System;

class Program
{
    static void Main(string[] args)
    {
        // bool mainMenu = true;
        bool running = true;
        List<Scripture> scriptureList = CreateDefaults();

        // Add a main menu to memorize or add a scripture
        // turn this into a function...
        RunMainMenu();

        while (running)
        {
            // change this to a function to randomly load a scripture
            scriptureList[scriptureList.Count() - 1].DisplayScripture();

            Console.WriteLine("Press <enter> to hide a word or type <menu> to return to the main menu.");
            // var input = Console.ReadKey();
            // if(input.Key == ConsoleKey.Enter){
            //     Console.WriteLine("Enter pressed");
            // }
            // else if(input.ToString() == "quit"){
            //     Console.WriteLine("Entered Quit");
            // }
            // else {
            //     Console.WriteLine("something else.");
            //     running = false;
            // }


            string input = Console.ReadLine().ToLower();
            if (input == "")
            {
                // randomly change hidden property on a word
                // reload scripture
            }
            else if (input == "menu")
            {
                Console.WriteLine("User pressed quit");
                // running = false;
                Console.Clear();
                RunMainMenu();
            }
            else
            {
                Console.WriteLine("Please type enter or quit.");
            }



        }


        // ----- Functions -----

        void RunMainMenu()
        {
            bool mainMenu = true;

            while (mainMenu)
            {
                Console.WriteLine("Select from the following options:\n1 to memorize a random scripture.\n2 to add a scripture.\nType <quit> to exit the program.");
                string selection = Console.ReadLine();
                int selectionInt;

                bool isInt = int.TryParse(selection, out selectionInt);

                if (isInt)
                {
                    if (selectionInt == 1)
                    {
                        mainMenu = false;
                        Console.Clear();
                        break;
                    }
                    else if (selectionInt == 2)
                    {
                        // add scripture and ref
                        Console.WriteLine("Add scripture selected.");
                        string temp = Console.ReadLine();
                        Console.WriteLine("Scripture Added...");

                        // ------ pasted ------

                        // scriptureList is the actual list
                        Console.WriteLine("Please enter the scripture reference in the following format\nbook,chapter,start verse, end verse.");
                        // move this to the class. remove / hide from this
                        string reference = Console.ReadLine();

                        Reference fullReference = new Reference(reference);

                        Console.WriteLine("Please enter the scripture.");
                        string[] newScripture = Console.ReadLine().Split(" ");
                        List<Word> newWords = new List<Word>();

                        foreach (var word in newScripture)
                        {
                            Word newWord = new Word(word);
                            newWords.Add(newWord);
                        }

                        Scripture addScripture = new Scripture(newWords); // takes words
                        addScripture.SetReference(fullReference);
                        scriptureList.Add(addScripture);

                        // ----- end pasted ----
                    }
                    else
                    {
                        Console.WriteLine("--Please enter a valid input.--");
                    }
                }
                else
                { // not int
                    if (selection.ToLower() == "quit")
                    {
                        Console.WriteLine("Goodbye...");
                        mainMenu = false;
                        running = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("--Please enter a valid input.--");
                    }
                }
            }
        }

        List<Scripture> CreateDefaults()
        {
            List<Scripture> list = new List<Scripture>(); // this is the final list we'll return. Should have two full scriptures. Text and Ref

            Reference _defaultRef1 = new Reference("John", 3, 16);
            Reference _defaultRef2 = new Reference("Proverbs", 4, 5, 6);

            List<string> scriptureText = new List<string>();

            scriptureText.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            scriptureText.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding.\n\nIn all thy ways acknowledge him, and he shall direct thy paths.");

            foreach (var scripture in scriptureText)
            {
                List<Word> scriptureWordList = new List<Word>(); // list of words that make up the scripture
                string[] sentenceParts = scripture.Split(" ");
                foreach (var word in sentenceParts)
                {
                    Word part = new Word(word); // create the Word
                    scriptureWordList.Add(part); // add to the list that makes up the scripture
                }

                Scripture newScripture = new Scripture(scriptureWordList);
                list.Add(newScripture);
            }

            list[0].SetReference(_defaultRef1);
            list[1].SetReference(_defaultRef2);

            return list;
        }

    }

}