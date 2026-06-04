using System;
using System.Collections.Generic;

public class Menu
{
    private List<string> _jlbOptions;

    public Menu()
    {
        _jlbOptions = new List<string>
        {
            "Write a new entry",
            "Display the journal",
            "Save the journal to a file",
            "Load the journal from a file",
            "Quit"
        };
    }

    public void jlbDisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");

        for (int jlbIndex = 0; jlbIndex < _jlbOptions.Count; jlbIndex++)
        {
            Console.WriteLine($"{jlbIndex + 1}. {_jlbOptions[jlbIndex]}");
        }
    }

    public int jlbGetChoice()
    {
        Console.Write("What would you like to do? ");
        string jlbUserInput = Console.ReadLine();

        int jlbChoice;

        while (!int.TryParse(jlbUserInput, out jlbChoice) || jlbChoice < 1 || jlbChoice > _jlbOptions.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
            Console.Write("What would you like to do? ");
            jlbUserInput = Console.ReadLine();
        }

        return jlbChoice;
    }
}