using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -)
        int lastDigit = percent % 10;


        // F never has + or -
        if (letter != "F") 
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case: No A+ grade
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Print the grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass/fail message
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}