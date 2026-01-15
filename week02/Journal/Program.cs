using System;

/// <summary>
/// Main program class.
/// Requirement: Provide a menu for user interaction.
/// Exceeding: Uses CSV save/load for entries.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {
            // Requirement: Provide menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a CSV file");
            Console.WriteLine("4. Load the journal from a CSV file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Requirement: Write a new entry
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                // Requirement: Display the journal
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Requirement: Save journal to file
                Console.Write("Enter filename (e.g., journal.csv): ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                // Requirement: Load journal from file
                Console.Write("Enter filename (e.g., journal.csv): ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }
    }
}