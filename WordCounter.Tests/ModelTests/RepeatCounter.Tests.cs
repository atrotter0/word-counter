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
            newCounter.SetUserWord("dog");
            Assert.AreEqual("dog", newCounter.GetUserWord());
        }
    }
}
