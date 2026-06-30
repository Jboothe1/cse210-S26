using System;

/*
    Name: Josh Boothe
    Class: CSE 210
    Description:
        Mindfulness Program using inheritance. The program provides breathing,
        reflecting, and listing activities.

    Creativity / Exceeding Requirements:
        This program makes sure random prompts and questions are not repeated
        until all available prompts/questions have been used once during that
        activity session. This was done using used-item lists in the activity
        classes.
*/

class Program
{
    static void Main(string[] args)
    {
        string jlbChoice = "";

        while (jlbChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            jlbChoice = Console.ReadLine();

            if (jlbChoice == "1")
            {
                BreathingActivity jlbBreathingActivity = new BreathingActivity();
                jlbBreathingActivity.JlbRun();
            }
            else if (jlbChoice == "2")
            {
                ReflectingActivity jlbReflectingActivity = new ReflectingActivity();
                jlbReflectingActivity.JlbRun();
            }
            else if (jlbChoice == "3")
            {
                ListingActivity jlbListingActivity = new ListingActivity();
                jlbListingActivity.JlbRun();
            }
            else if (jlbChoice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}