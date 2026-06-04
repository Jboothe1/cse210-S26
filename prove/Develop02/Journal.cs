using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _jlbEntries;

    public Journal()
    {
        _jlbEntries = new List<Entry>();
    }

    public void jlbAddEntry(Entry jlbEntry)
    {
        _jlbEntries.Add(jlbEntry);
    }

    public void jlbDisplayJournal()
    {
        if (_jlbEntries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (Entry jlbEntry in _jlbEntries)
            {
                jlbEntry.jlbDisplayEntry();
            }
        }
    }

    public void jlbSaveToFile(string jlbFilename)
    {
        using (StreamWriter jlbOutputFile = new StreamWriter(jlbFilename))
        {
            foreach (Entry jlbEntry in _jlbEntries)
            {
                jlbOutputFile.WriteLine(jlbEntry.jlbConvertToFileString());
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void jlbLoadFromFile(string jlbFilename)
    {
        _jlbEntries.Clear();

        string[] jlbLines = System.IO.File.ReadAllLines(jlbFilename);

        foreach (string jlbLine in jlbLines)
        {
            string[] jlbParts = jlbLine.Split("|");

            string jlbDate = jlbParts[0];
            string jlbPrompt = jlbParts[1];
            string jlbResponse = jlbParts[2];

            Entry jlbEntry = new Entry(jlbDate, jlbPrompt, jlbResponse);
            _jlbEntries.Add(jlbEntry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}