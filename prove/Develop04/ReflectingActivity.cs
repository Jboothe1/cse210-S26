using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _jlbPrompts;
    private List<string> _jlbQuestions;
    private List<string> _jlbUsedPrompts;
    private List<string> _jlbUsedQuestions;

    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _jlbPrompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _jlbQuestions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _jlbUsedPrompts = new List<string>();
        _jlbUsedQuestions = new List<string>();
    }

    public void JlbRun()
    {
        JlbDisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {JlbGetPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        JlbShowSpinner(4);
        Console.Clear();

        DateTime jlbStartTime = DateTime.Now;
        DateTime jlbEndTime = jlbStartTime.AddSeconds(JlbGetDuration());

        while (DateTime.Now < jlbEndTime)
        {
            Console.Write($"> {JlbGetQuestion()} ");
            JlbShowSpinner(6);
            Console.WriteLine();
        }

        JlbDisplayEndingMessage();
    }

    private string JlbGetPrompt()
    {
        return JlbGetRandomUnusedItem(_jlbPrompts, _jlbUsedPrompts);
    }

    private string JlbGetQuestion()
    {
        return JlbGetRandomUnusedItem(_jlbQuestions, _jlbUsedQuestions);
    }
}