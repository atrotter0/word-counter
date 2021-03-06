using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord;
        private string _userPhrase;
        private string _scrubbedPhrase;
        private int _wordCount;

        public void SetUserWord(string word)
        {
            _userWord = word.ToLower().Trim();
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public void SetUserPhrase(string phrase)
        {
            _userPhrase = phrase;
        }

        public string GetUserPhrase()
        {
            return _userPhrase;
        }

        public void SetScrubbedPhrase(string phrase)
        {
            _scrubbedPhrase = phrase;
        }

        public string GetScrubbedPhrase()
        {
            return _scrubbedPhrase;
        }

        public int GetWordCount()
        {
            return _wordCount;
        }

        public void SetWordCount(int number)
        {
            _wordCount = number;
        }

        public void IncrementWordCount()
        {
            _wordCount++;
        }

        public void ResetWordCount()
        {
            this.SetWordCount(0);
        }

        public bool IsNullWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return true;
            return false;
        }

        public bool IsValidWord(string word)
        {
            foreach (char letter in word)
            {
                if (!Char.IsLetter(letter)) return false;
            }
            return true;
        }

        public void DowncaseAndScrubPhrase()
        {
            string[] words = this.GetUserPhrase().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = this.ScrubPunctuation(words[i].ToLower());
            }
            string lowercaseAndScrubbed = string.Join(" ", words);
            this.SetScrubbedPhrase(lowercaseAndScrubbed);
        }

        public string ScrubPunctuation(string phrase)
        {
            char[] letters = phrase.ToCharArray();
            List<char> lettersAndSpaces = new List<char>() {};
            foreach (char letter in letters)
            {
                this.AddLettersAndSpaces(letter, lettersAndSpaces);
            }
            string scrubbedWord = string.Join("", lettersAndSpaces);
            return scrubbedWord;
        }

        public void AddLettersAndSpaces(char letter, List<char> lettersAndSpaces)
        {
            if (Char.IsLetter(letter) || Char.IsWhiteSpace(letter)) lettersAndSpaces.Add(letter);
        }

        public int FindWordMatches()
        {
            this.ResetWordCount();
            string [] words = this.GetScrubbedPhrase().Split(' ');
            foreach (string word in words)
            {
                this.IncrementIfWordMatch(word);
            }
            return this.GetWordCount();
        }

        public void IncrementIfWordMatch(string word)
        {
            if (this.GetUserWord() == word) this.IncrementWordCount();
        }
    }
}
