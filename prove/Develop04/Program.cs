using System;

class Program
{
    static void Main(string[] args)
    {




        // breathing.StartBreathing();
        // reflection.StartReflection();

        int selection = MainMenu();
        LaunchActivity(selection);


        void Exit() //!! Clean this up!!
        {
            Console.Write("Goodbye.");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("..");

            }
            Console.Clear();
            //!! Idea
            // var loaderChars = new[] { '/', '-', '\\', '|' };
            // var a = 0;

            // while (true)
            // {
            //     Console.SetCursorPosition(0, Console.CursorTop);
            //     Console.Write(loaderChars[a++]);
            //     a = a == loaderChars.Length ? 0 : a;
            //     Thread.Sleep(300);
            // }



            Environment.Exit(0);
        }

        void LaunchActivity(int selected)
        {
            Console.WriteLine($"User selection: {selected}");
            switch (selected)
            {
                case 1:
                    Breathing breathing = new();
                    breathing.Start();
                    breathing.BreathingActivity();
                    break;
                case 2:
                    Reflection reflection = new();
                    reflection.Start();
                    break;
                case 3:
                    Listening listening = new();
                    break;
                default:
                    Console.WriteLine("Something happened...pull out exit maybe?");
                    Exit();
                    break;
            }
        }

        int MainMenu()
        {
            Console.WriteLine("Menu Options:\n1. start breathing activity\n2. Start reflecting activity\n3. Start listening activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string selection = Console.ReadLine();
            int selectionInt;

            bool isInt = int.TryParse(selection, out selectionInt);

            if (isInt && selectionInt >= 1 && selectionInt <= 4)
            {
                if (selectionInt == 4)
                {
                    Exit();
                }
                return selectionInt;
            }
            else
            {
                Console.WriteLine("Next time please try to enter a valid selection.");
                Exit();
                return 0;
            }


        }





    }
}
