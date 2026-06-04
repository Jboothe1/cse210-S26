using System;
using System.Collections.Generic;

// Source:
// PromptGenerator class structure and code were created with help from ChatGPT.
// Assignment requirements came from the CSE 210 Journal Program instructions.
public class PromptGenerator
{
    private List<string> _jlbPrompts;
    private Random _jlbRandom;

    public PromptGenerator()
    {
        _jlbPrompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What is one thing I am grateful for today?",
            "What is something I want to improve tomorrow?"
        };

        _jlbRandom = new Random();
    }

    public string jlbGetRandomPrompt()
    {
        int jlbIndex = _jlbRandom.Next(_jlbPrompts.Count);
        return _jlbPrompts[jlbIndex];
    }
}