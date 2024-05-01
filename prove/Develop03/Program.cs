using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        Console.WriteLine("Please pick from the following options:");

        while (running)
        {
            Console.WriteLine("Type <Enter> to hide lines. Type <add> to add a scripture. Type <quit> to exit.");
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
                Console.WriteLine("User pressed Enter");
                Reference _myReference = new Reference("John", 3, 16);
                Reference _myReference2 = new Reference("Proverbs", 4, 5, 8);

                Console.WriteLine(_myReference.GetReference());
                Console.WriteLine(_myReference2.GetReference());

                List<Word> words = new List<Word>();

                // Split string on space
                // foreach add to list
                string sentence = "This is a complete sentence.";
                string[] sentenceParts = sentence.Split(" ");

                foreach (var word in sentenceParts)
                {
                    Word part = new Word(word);
                    words.Add(part);
                }
                // Word _this = new Word("This");
                // Word _is = new Word("is");
                // Word _the = new Word("the");
                // Word _way = new Word("way");

                // words.Add(_this);
                // words.Add(_is);
                // words.Add(_the);
                // words.Add(_way);

                Scripture newScripture = new Scripture(words);
                newScripture.SetReference(_myReference2);

                List<Word> listOfWords = newScripture.GetWords();

                Console.WriteLine(newScripture.GetReference().GetReference());
                foreach (var word in listOfWords)
                {
                    Console.Write($"{word.GetText()} ");

                }
                Console.WriteLine();

            }
            else if (input == "quit")
            {
                Console.WriteLine("User pressed quit");
                running = false;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Please type enter or quit.");
            }



        }
    }
}