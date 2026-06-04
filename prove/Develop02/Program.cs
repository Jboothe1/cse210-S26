using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity / Exceeding Requirements:
        // I added a separate PromptGenerator class to keep prompt logic separate
        // from Program.cs. I also included more than five prompts.

        Menu jlbMenu = new Menu();
        Journal jlbJournal = new Journal();
        PromptGenerator jlbPromptGenerator = new PromptGenerator();

        int jlbChoice = 0;

        while (jlbChoice != 5)
        {
            jlbMenu.jlbDisplayMenu();
            jlbChoice = jlbMenu.jlbGetChoice();

            if (jlbChoice == 1)
            {
                string jlbPrompt = jlbPromptGenerator.jlbGetRandomPrompt();

                Console.WriteLine(jlbPrompt);
                Console.Write("> ");
                string jlbResponse = Console.ReadLine();

                string jlbDate = DateTime.Now.ToShortDateString();

                Entry jlbEntry = new Entry(jlbDate, jlbPrompt, jlbResponse);
                jlbJournal.jlbAddEntry(jlbEntry);
            }
            else if (jlbChoice == 2)
            {
                jlbJournal.jlbDisplayJournal();
            }
            else if (jlbChoice == 3)
            {
                Console.Write("What is the filename? ");
                string jlbFilename = Console.ReadLine();

                jlbJournal.jlbSaveToFile(jlbFilename);
            }
            else if (jlbChoice == 4)
            {
                Console.Write("What is the filename? ");
                string jlbFilename = Console.ReadLine();

                jlbJournal.jlbLoadFromFile(jlbFilename);
            }
            else if (jlbChoice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            Console.WriteLine();
        }
    }
}