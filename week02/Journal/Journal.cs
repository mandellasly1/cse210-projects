using System;
using System.Collections.Generic;
using System.IO;


/// Represents the journal as a collection of entries.
/// Requirement: Add, display, save, and load entries.
/// Exceeding: Save/load entries in CSV format.

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    
    /// Requirement: Add a new entry to the journal.
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    
    /// Requirement: Display all entries in the journal.
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    /// Requirement: Save the journal to a file.
    /// Exceeding: Save entries in proper CSV format.
   
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToCsv());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    
    /// Requirement: Load the journal from a file.
    /// Exceeding: Load entries from proper CSV format.
    
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = Entry.FromCsv(line);
            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}