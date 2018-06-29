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
        public void GetSetUserPhrase_GetsSetsUserPhrase_String()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string phrase = "This is the end, the end my friend.";
            newCounter.SetUserPhrase(phrase);
            Assert.AreEqual(phrase, newCounter.GetUserPhrase());
        }

        [TestMethod]
        public void GetSetScrubbedPhrase_GetsSetsScrubbedPhrase_String()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetScrubbedPhrase("this is the end the end my friend");
            Assert.AreEqual("this is the end the end my friend", newCounter.GetScrubbedPhrase());
        }

        [TestMethod]
        public void GetIncrementWordCount_GetsAndIncrementsWordCount_Int()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.IncrementWordCount();
            Assert.AreEqual(1, newCounter.GetWordCount());
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
        public void DowncaseAndScrubPhrase_DowncasesUserPhrase_True()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string phrase = "This is the end, the END my friend.";
            newCounter.SetUserPhrase(phrase);
            newCounter.DowncaseAndScrubPhrase();
            string expectedOutput = "this is the end the end my friend";
            Assert.AreEqual(expectedOutput, newCounter.GetScrubbedPhrase());
        }

        [TestMethod]
        public void ScrubPunctuation_RemovesPunctuationFromString_String()
        {
            RepeatCounter newCounter = new RepeatCounter();
            string phraseWithPunctuation = "This is the end, the end my friend!";
            string stripped = "This is the end the end my friend";
            Assert.AreEqual(stripped, newCounter.ScrubPunctuation(phraseWithPunctuation));
        }

        [TestMethod]
        public void FindWordMatches_CountsUserWordInPhrase_Int()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetUserWord("goblins");
            newCounter.SetScrubbedPhrase("the goblins are everywhere dont get surrounded by the goblins");
            newCounter.FindWordMatches();
            Assert.AreEqual(2, newCounter.GetWordCount());
        }
    }
}
