﻿using Katas.LeetCode;
using NUnit.Framework;

namespace Tests.LeetCode
{
    public class RansomNoteTest
    {
        [Test]
        [TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void Test(string note, string magazine, bool expectedOutput)
        {
            var ransomNote = new RansomNote();
            var result = ransomNote.CanConstruct(note, magazine);
            Assert.AreEqual(result, expectedOutput);
        }
    }
}
