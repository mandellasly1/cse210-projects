using System;

/// <summary>
/// Represents a single journal entry.
/// Requirement: Store the date, prompt, and text of an entry.
/// Exceeding: Provides CSV conversion methods.
/// </summary>
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

    /// <summary>
    /// Requirement: Display a single entry to the console.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}");
        Console.WriteLine(Text);
        Console.WriteLine();
    }

    /// <summary>
    /// Exceeding Requirement: Convert entry to a CSV line (with quotes for safety).
    /// </summary>
    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt}\",\"{Text}\"";
    }

    /// <summary>
    /// Exceeding Requirement: Create entry from a CSV line.
    /// </summary>
    public static Entry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split("\",\"");
        string date = parts[0].Trim('"');
        string prompt = parts[1].Trim('"');
        string text = parts[2].Trim('"');
        return new Entry(date, prompt, text);
    }
}