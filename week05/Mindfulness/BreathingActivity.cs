using System;

// ENHANCEMENT: 
// - Uses enhanced breathing animation with visual expansion/contraction
// - Implements the base class methods with specific breathing patterns
// - Provides a natural breathing rhythm through slowing down near the end
// - Includes visual feedback with animated text
// - Prevents duplicate prompts by using the base class's GetRandomItem method

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            AnimatedBreatheIn(4);
            
            if (DateTime.Now >= endTime) break;
            
            AnimatedBreatheOut(6);
        }
        
        DisplayEndingMessage();
    }
}