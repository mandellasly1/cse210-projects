using System;
using System.Collections.Generic;

// ENHANCEMENT:
// - Prevents duplicate prompts by tracking used items
// - Uses GetRandomItem() from base class to ensure no repeats
// - Provides a structured listing experience
// - Includes visual feedback with spinner animation
// - Maintains clean separation of concerns

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _usedPrompts;
    private int _count;

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
        _usedPrompts = new List<string>();
        _count = 0;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        
        DisplayPrompt();
        
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        
        GetListFromUser();
        
        Console.WriteLine($"You listed {_count} items!");
        
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        // Use the base class method to get a random prompt
        // This ensures no duplicates until all prompts are used
        string prompt = GetRandomItem(_prompts, _usedPrompts);
        
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
    }

    private void GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
    }
}