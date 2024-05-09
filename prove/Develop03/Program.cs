using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<Scripture> scriptureList = CreateDefaults();

        RunMainMenu();

        // randomly load scripture
        var rand = new Random();
        // need to save this so i know which scripture until end
        Scripture currentScripture = scriptureList[rand.Next(scriptureList.Count)]; //!! need to move this. pulls a new scripture

        List<int> hiddenIndex = new List<int>();
        int count = 0;

        while (running)
        {

            Console.Clear();

            currentScripture.DisplayScripture();

            Console.WriteLine("Press <enter> to hide a word or type <menu> to return to the main menu.");

            string input = Console.ReadLine().ToLower();

            if (input == "")
            {

                // while get an int
                bool selected = false;
                int randomInt = 0;
                int randomNum = 1;
                int countWordsRemaining = currentScripture.VisibleWordsRemaining();

                if (countWordsRemaining >= 3)
                {
                    randomNum = rand.Next(1, 4);
                }
                // else
                // {
                //     randomNum = rand.Next(1, countWordsRemaining);
                // }


                for (int i = 0; i < randomNum; i++)
                {
                    selected = false;

                    while (!selected)
                    {
                        randomInt = rand.Next(currentScripture.GetWords().Count);

                        if (!hiddenIndex.Contains(randomInt))
                        {
                            hiddenIndex.Add(randomInt);
                            selected = true;
                            count++;
                        }

                        currentScripture.GetWords()[randomInt].SetHidden(true);
                    }
                }




                // change this to random, store random to not select again
                // reload scripture
                currentScripture.DisplayScripture(); // !!this is exiting and reloading another scripture as wel...

                if (count == currentScripture.GetWords().Count)
                {
                    //?? move all this to a reset method?
                    count = 0; // reset word counter otherwise program will never enter this block after first time
                    // running = false;
                    currentScripture.ShowAll(); // make all words visible again
                    hiddenIndex.Clear(); // reset list of hidden word indexes
                    Console.Clear();
                    // Console.WriteLine("The full scripture is hidden");
                    // Console.ReadLine();
                    currentScripture = scriptureList[rand.Next(scriptureList.Count)]; // new random scripture
                    RunMainMenu(); //!! need to pick a random scripture after this...or maybe it is random? I only have a couple. Figure out which line it jumps to.
                }

            }
            else if (input == "menu")
            {
                Console.WriteLine("User pressed quit");
                running = false;
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