using System;
using System.Collections.Generic;

// ENHANCEMENT:
// - Prevents duplicate prompts and questions by tracking used items
// - Uses GetRandomItem() from base class to ensure no repeats until all used
// - Provides a structured reflection experience with guided questions
// - Includes visual feedback with spinner animation
// - Maintains clean separation of concerns

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedPrompts;
    private List<string> _usedQuestions;

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
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
        
        _usedPrompts = new List<string>();
        _usedQuestions = new List<string>();
    }

    public override void Run()
    {
        DisplayStartingMessage();
        
        DisplayPrompt();
        
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        
        Console.Clear();
        DisplayQuestions();
        
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        // Use the base class method to get a random prompt
        // This ensures no duplicates until all prompts are used
        string prompt = GetRandomItem(_prompts, _usedPrompts);
        
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Random random = new Random();
        
        while (DateTime.Now < endTime)
        {
            // Use the base class method to get a random question
            // This ensures no duplicates until all questions are used
            string question = GetRandomItem(_questions, _usedQuestions);
            
            Console.Write($"> {question} ");
            ShowSpinner(10);
            Console.WriteLine();
            
            if (DateTime.Now >= endTime) break;
        }
    }
}