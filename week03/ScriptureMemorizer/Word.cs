namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor
        public Word(string text)
        {
            _text = text;
            _isHidden = false; // Words start as visible
        }

        // Method to hide the word
        public void Hide()
        {
            _isHidden = true;
        }

        // Method to check if word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Method to get the display text (either the word or underscores)
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                // Replace each letter with an underscore
                return new string('_', _text.Length);
            }
            else
            {
                return _text;
            }
        }

        // Method to get the original text
        public string GetText()
        {
            return _text;
        }
    }
}