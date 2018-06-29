using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord;
        private string _userPhrase;

        public void SetUserWord(string word)
        {
            _userWord = word.ToLower();
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public bool IsValidWord(string word)
        {
            foreach (char letter in word)
            {
                if (!Char.IsLetter(letter)) return false;
            }
            return true;
        }

        public void SetUserPhrase(string phrase)
        {
            _userPhrase = phrase;
        }

        public string GetUserPhrase()
        {
            return _userPhrase;
        }

        public void DowncasePhrase()
        {
            string[] words = this.GetUserPhrase().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }
            string lowercasePhrase = string.Join(" ", words);
            this.SetUserPhrase(lowercasePhrase);
        }
    }
}
