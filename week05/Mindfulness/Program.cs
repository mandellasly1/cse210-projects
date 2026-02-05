using System;

// ENHANCEMENTS EXCEEDED REQUIREMENTS:
//  Prevent duplicate prompts/questions: Implemented in base class with GetRandomItem()
//    - Tracks used prompts/questions in separate lists
//    - Automatically resets when all items are used
//    - Ensures variety in user experience
//    - Uses LINQ to filter available options
//
//  Enhanced breathing animation: Created animated breathing that visually expands 
//    during inhale and contracts during exhale. The animation slows down near the end 
//    of each breath cycle to create a more natural breathing rhythm, helping users 
//    pace themselves more effectively.
//
//  Input validation: Added validation for menu choices to prevent crashes from 
//    invalid input.
//
//  Improved user experience: Clear screen between activities and graceful exit messages.
//
//  Code organization: All enhancements are in the base class, so derived classes 
//    are simple and maintainable.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nThank you Well Done. see you Soon!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please select 1-4.");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}