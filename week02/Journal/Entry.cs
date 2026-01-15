using System;


/// Represents a single journal entry.
/// Requirement: Store the date, prompt, and text of an entry.
/// Exceeding: Provides CSV conversion methods.

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Text { get; set; }

    public Entry(string date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }

   
    /// Requirement: Display a single entry to the console.
    
    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}");
        Console.WriteLine(Text);
        Console.WriteLine();
    }

    
    /// Exceeding Requirement: Convert entry to a CSV line (with quotes for safety).
    
    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt}\",\"{Text}\"";
    }

    
    /// Exceeding Requirement: Create entry from a CSV line.
    
    public static Entry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split("\",\"");
        string date = parts[0].Trim('"');
        string prompt = parts[1].Trim('"');
        string text = parts[2].Trim('"');
        return new Entry(date, prompt, text);
    }
}