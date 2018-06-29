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

        public void StripPunctuation(string phrase)
        {
            char[] letters = phrase.ToCharArray();
            List<char> notPunctation = new List<char>() {};
            for (int i = 0; i < letters.Length; i++)
            {
                if (!Char.IsPunctuation(letters[i])) notPunctation.Add(letters[i]);
            }
            string strippedPhrase = string.Join("", notPunctation);
            this.SetUserPhrase(strippedPhrase);
        }
    }
}
