using System;

public class Entry
{
    private string _jlbDate;
    private string _jlbPrompt;
    private string _jlbResponse;

    public Entry(string jlbDate, string jlbPrompt, string jlbResponse)
    {
        _jlbDate = jlbDate;
        _jlbPrompt = jlbPrompt;
        _jlbResponse = jlbResponse;
    }

    public void jlbDisplayEntry()
    {
        Console.WriteLine($"Date: {_jlbDate}");
        Console.WriteLine($"Prompt: {_jlbPrompt}");
        Console.WriteLine($"Response: {_jlbResponse}");
        Console.WriteLine();
    }

    public string jlbConvertToFileString()
    {
        return $"{_jlbDate}|{_jlbPrompt}|{_jlbResponse}";
    }
}