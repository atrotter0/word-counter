using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord;

        public void SetUserWord(string word)
        {
            _userWord = word;
        }

        public string GetUserWord()
        {
            return _userWord;
        }
    }
}
