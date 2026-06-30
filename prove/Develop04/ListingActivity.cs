using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _jlbPrompts;
    private List<string> _jlbUsedPrompts;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _jlbPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _jlbUsedPrompts = new List<string>();
    }

    public void JlbRun()
    {
        JlbDisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {JlbGetPrompt()} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        JlbShowCountdown(5);
        Console.WriteLine();

        DateTime jlbStartTime = DateTime.Now;
        DateTime jlbEndTime = jlbStartTime.AddSeconds(JlbGetDuration());

        int jlbItemCount = 0;

        while (DateTime.Now < jlbEndTime)
        {
            Console.Write("> ");
            string jlbUserItem = Console.ReadLine();

            if (jlbUserItem != "")
            {
                jlbItemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {jlbItemCount} items.");

        JlbDisplayEndingMessage();
    }

    private string JlbGetPrompt()
    {
        return JlbGetRandomUnusedItem(_jlbPrompts, _jlbUsedPrompts);
    }
}