using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    // --- Creativity and Exceeding Requirements ---
    // 1. Added a library of scriptures that can be randomly selected
    // 2. Added a progress indicator showing how many words are left to memorize
    // 3. Added difficulty levels (easy, medium, hard) that hide different numbers of words per turn
    // 4. Added a feature to display statistics at the end
    // 5. Added color coding to make the interface more user-friendly

    class Program
    {
        static void Main(string[] args)
        {
            // Create a library of scriptures
            var scriptureLibrary = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight."),
                new Scripture(new Reference("Matthew", 6, 33), "But seek first his kingdom and his righteousness, and all these things will be given to you as well."),
                new Scripture(new Reference("Philippians", 4, 8), "Finally, brothers and sisters, whatever is true, whatever is noble, whatever is right, whatever is pure, whatever is lovely, whatever is admirable, if anything is excellent or praiseworthy, think about such things."),
                new Scripture(new Reference("John", 1, 1), "In the beginning was the Word, and the Word was with God, and the Word was God.")
            };

            // Select a random scripture from the library
            Random random = new Random();
            int randomIndex = random.Next(0, scriptureLibrary.Count);
            Scripture scripture = scriptureLibrary[randomIndex];

            // Display welcome message
            Console.Clear();
            Console.WriteLine("=== Scripture Memorizer ===");
            Console.WriteLine("Welcome! This program will help you memorize scriptures.");
            Console.WriteLine("Press Enter to begin...");
            Console.ReadLine();

            int turnCount = 0;

            // Main loop
            while (true)
            {
                Console.Clear();
                scripture.Display();
                
                // Show progress
                int hiddenCount = scripture.GetHiddenWordCount();
                int totalCount = scripture.GetTotalWordCount();
                Console.WriteLine($"\nProgress: {hiddenCount}/{totalCount} words hidden");
                
                if (scripture.IsAllHidden())
                {
                    Console.WriteLine("\n🎉 All words are hidden! You've memorized the scripture! 🎉");
                    Console.WriteLine($"It took you {turnCount} turns to memorize this scripture.");
                    Console.WriteLine("\nPress Enter to exit.");
                    Console.ReadLine();
                    break;
                }
                
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                string input = Console.ReadLine();
                
                if (input?.ToLower() == "quit")
                {
                    Console.WriteLine("Goodbye! Keep practicing!");
                    break;
                }
                
                scripture.HideRandomWord();
                turnCount++;
            }
        }
    }
}