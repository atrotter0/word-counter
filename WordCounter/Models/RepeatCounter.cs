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
            _userWord = word.ToLower();
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

        public void IncrementWordCount()
        {
            _wordCount++;
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
            string lowercasePhrase = string.Join(" ", words);
            this.SetScrubbedPhrase(lowercasePhrase);
        }

        public string ScrubPunctuation(string phrase)
        {
            char[] letters = phrase.ToCharArray();
            List<char> notPunctation = new List<char>() {};
            for (int i = 0; i < letters.Length; i++)
            {
                if (!Char.IsPunctuation(letters[i])) notPunctation.Add(letters[i]);
            }
            string scrubbedPhrase = string.Join("", notPunctation);
            return scrubbedPhrase;
        }

        // public bool FindWordMatches()
        // {
        //     for (int i = 0; i < this.GetScrubbedPhrase().Length; i++)
        //     {

        //     }
        // }
    }
}
