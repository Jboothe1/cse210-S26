using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private string _jlbName;
    private string _jlbDescription;
    private int _jlbDuration;

    protected Activity(string jlbName, string jlbDescription)
    {
        _jlbName = jlbName;
        _jlbDescription = jlbDescription;
        _jlbDuration = 0;
    }

    protected void JlbDisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_jlbName}.");
        Console.WriteLine();
        Console.WriteLine(_jlbDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        string jlbDurationInput = Console.ReadLine();
        _jlbDuration = int.Parse(jlbDurationInput);

        Console.Clear();
        Console.WriteLine("Get ready...");
        JlbShowSpinner(3);
        Console.WriteLine();
    }

    protected void JlbDisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        JlbShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_jlbDuration} seconds of the {_jlbName}.");
        JlbShowSpinner(3);
    }

    protected void JlbShowSpinner(int jlbSeconds)
    {
        List<string> jlbSpinnerCharacters = new List<string>();
        jlbSpinnerCharacters.Add("|");
        jlbSpinnerCharacters.Add("/");
        jlbSpinnerCharacters.Add("-");
        jlbSpinnerCharacters.Add("\\");

        DateTime jlbStartTime = DateTime.Now;
        DateTime jlbEndTime = jlbStartTime.AddSeconds(jlbSeconds);

        int jlbIndex = 0;

        while (DateTime.Now < jlbEndTime)
        {
            string jlbCharacter = jlbSpinnerCharacters[jlbIndex];

            Console.Write(jlbCharacter);
            Thread.Sleep(250);
            Console.Write("\b \b");

            jlbIndex++;

            if (jlbIndex >= jlbSpinnerCharacters.Count)
            {
                jlbIndex = 0;
            }
        }
    }

    protected void JlbShowCountdown(int jlbSeconds)
    {
        for (int jlbCount = jlbSeconds; jlbCount > 0; jlbCount--)
        {
            Console.Write(jlbCount);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int JlbGetDuration()
    {
        return _jlbDuration;
    }

    protected string JlbGetRandomUnusedItem(List<string> jlbItems, List<string> jlbUsedItems)
    {
        if (jlbUsedItems.Count == jlbItems.Count)
        {
            jlbUsedItems.Clear();
        }

        Random jlbRandom = new Random();
        string jlbSelectedItem = "";
        bool jlbFoundUnusedItem = false;

        while (!jlbFoundUnusedItem)
        {
            int jlbRandomIndex = jlbRandom.Next(jlbItems.Count);
            jlbSelectedItem = jlbItems[jlbRandomIndex];

            if (!jlbUsedItems.Contains(jlbSelectedItem))
            {
                jlbUsedItems.Add(jlbSelectedItem);
                jlbFoundUnusedItem = true;
            }
        }

        return jlbSelectedItem;
    }
}