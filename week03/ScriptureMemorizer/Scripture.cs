using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        // Constructor
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            _random = new Random();
            
            // Split the text into words and create Word objects
            string[] wordArray = text.Split(' ');
            foreach (string word in wordArray)
            {
                _words.Add(new Word(word));
            }
        }

        // Method to hide a random word
        public void HideRandomWord()
        {
            if (_words.Count == 0) return;

            // Pick a random word index
            int randomIndex = _random.Next(0, _words.Count);
            
            // Hide the word at that index
            _words[randomIndex].Hide();
        }

        // Method to hide multiple random words (for difficulty levels)
        public void HideRandomWords(int count)
        {
            for (int i = 0; i < count; i++)
            {
                HideRandomWord();
            }
        }

        // Method to check if all words are hidden
        public bool IsAllHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }

        // Method to display the scripture
        public void Display()
        {
            Console.WriteLine(_reference.GetDisplayText());
            Console.WriteLine();

            // Display each word
            foreach (Word word in _words)
            {
                Console.Write(word.GetDisplayText() + " ");
            }
            Console.WriteLine();
        }

        // Method to get the number of hidden words
        public int GetHiddenWordCount()
        {
            int count = 0;
            foreach (Word word in _words)
            {
                if (word.IsHidden())
                {
                    count++;
                }
            }
            return count;
        }

        // Method to get the total number of words
        public int GetTotalWordCount()
        {
            return _words.Count;
        }

        // Method to get the original text (for display after completion)
        public string GetOriginalText()
        {
            string text = "";
            foreach (Word word in _words)
            {
                text += word.GetText() + " ";
            }
            return text.Trim();
        }
    }
}