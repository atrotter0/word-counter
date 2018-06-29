using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void GetSetUserWord_GetsSetsUserWord_String()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetUserWord("DOG");
            Assert.AreEqual("dog", newCounter.GetUserWord());
        }

        [TestMethod]
        public void IsValidWord_ChecksWordForInvalidCharacters_False()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string input = "%$DHOG&*";
            Assert.AreEqual(false, newCounter.IsValidWord(input));
        }

        [TestMethod]
        public void IsValidWord_ChecksWordForInvalidCharacters_True()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string input = "cat";
            Assert.AreEqual(true, newCounter.IsValidWord(input));
        }

        [TestMethod]
        public void GetSetUserPhrase_GetsSetsUserPhrase_String()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string phrase = "This is the end, the end my friend.";
            newCounter.SetUserPhrase(phrase);
            Assert.AreEqual(phrase, newCounter.GetUserPhrase());
        }

        [TestMethod]
        public void DowncasePhrase_DowncasesUserPhrase_True()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string phrase = "This is the end, the END my friend.";
            newCounter.SetUserPhrase(phrase);
            newCounter.DowncasePhrase();
            string expectedOutput = "this is the end, the end my friend.";
            Assert.AreEqual(expectedOutput, newCounter.GetUserPhrase());
        }
    }
}
