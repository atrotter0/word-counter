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
        public void GetSetUserWord_GetsSetsUserWord_True()
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
    }
}
