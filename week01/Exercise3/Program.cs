using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable to control whether the user wants to play again or restart the game 
        string playAgain = "yes";

        // Outer loop: keeps running the game until the user says "no"
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();

            int magicNumber = randomGenerator.Next(1, 101);

            // Initialize guess and guess counter
            int guess = -1;

            int guessCount = 0;

            // Inform the user that a number has been chosen
            Console.WriteLine("I have picked a magic number between 1 and 100.");

            // Inner loop: keeps asking for guesses until the user guesses correctly
            while (guess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");

                guess = int.Parse(Console.ReadLine());

                // Increment the number of guesses
                guessCount++;

                // Compare the guess with the magic number
                if (magicNumber > guess)
                {
                    // Tell the user to guess higher
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    // Tell the user to guess lower
                    Console.WriteLine("Lower");
                }
                else
                {
                    // User guessed correctly — congratulate them and show attempts
                    Console.WriteLine("You guessed it");
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            }

            // After the game ends, ask if the user wants to play again
            Console.Write("Do you want to play again (yes/no)? ");
            
            playAgain = Console.ReadLine();
        }

        // Exit message after the user chooses not to play again
        Console.WriteLine("Well played!");
    }
}