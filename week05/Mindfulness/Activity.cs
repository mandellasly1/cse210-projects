using System;
using System.Collections.Generic;
using System.Threading;

// Base class for all mindfulness activities
// Includes common functionality and enhanced animations
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Display the starting message common to all activities
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display the ending message common to all activities
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(3);
        
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    // Enhanced spinner animation with multiple characters
    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % animationStrings.Count;
        }
    }

    // Countdown timer that displays decreasing numbers
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            // Handle double-digit to single-digit transition
            if (i >= 10 && i - 1 < 10)
            {
                Console.Write("\b");
            }
        }
    }

    // ENHANCEMENT: Get a random item from a list without repeating until all are used
    // This method ensures variety in prompts and questions
    protected string GetRandomItem(List<string> sourceList, List<string> usedList)
    {
        // Reset if all items have been used
        if (usedList.Count >= sourceList.Count)
        {
            usedList.Clear();
        }

        // Create a list of available items (not yet used)
        List<string> availableItems = new List<string>();
        foreach (string item in sourceList)
        {
            if (!usedList.Contains(item))
            {
                availableItems.Add(item);
            }
        }

        // Select a random item from available items
        Random random = new Random();
        int index = random.Next(availableItems.Count);
        string selectedItem = availableItems[index];
        
        // Mark this item as used
        usedList.Add(selectedItem);
        
        return selectedItem;
    }

    // ENHANCEMENT: Animated breathing in with visual expansion effect
    // Text expands and slows down near the end for natural breathing rhythm
    protected void AnimatedBreatheIn(int seconds)
    {
        int steps = seconds * 2; // 2 steps per second for smooth animation
        int msPerStep = 500;
        
        for (int i = 1; i <= steps; i++)
        {
            Console.Write("\r"); // Return to start of line
            
            // Create visual expansion with circles
            string visual = new string('○', i);
            int timeLeft = seconds - (i / 2);
            
            Console.Write($"Breathe in... {visual} ({timeLeft})");
            
            // Slow down near the end (last 30% of breath)
            if (i > steps * 0.7)
            {
                Thread.Sleep(msPerStep + 200); // Add 200ms delay
            }
            else
            {
                Thread.Sleep(msPerStep);
            }
        }
        
        Console.Write("\r" + new string(' ', 60) + "\r"); // Clear the line
    }

    // ENHANCEMENT: Animated breathing out with visual contraction effect
    // Text contracts and slows down near the end for natural breathing rhythm
    protected void AnimatedBreatheOut(int seconds)
    {
        int steps = seconds * 2; // 2 steps per second for smooth animation
        int msPerStep = 500;
        
        for (int i = steps; i >= 1; i--)
        {
            Console.Write("\r"); // Return to start of line
            
            // Create visual contraction with circles
            string visual = new string('○', i);
            int timeLeft = seconds - ((steps - i) / 2);
            
            Console.Write($"Now breathe out... {visual} ({timeLeft})");
            
            // Slow down near the end (last 30% of breath)
            if (i < steps * 0.3)
            {
                Thread.Sleep(msPerStep + 200); // Add 200ms delay
            }
            else
            {
                Thread.Sleep(msPerStep);
            }
        }
        
        Console.Write("\r" + new string(' ', 60) + "\r"); // Clear the line
    }

    // Virtual method to be overridden by derived classes
    public virtual void Run()
    {
        // This will be implemented by each specific activity
    }
}