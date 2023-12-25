using System;
using System.Linq;
using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class WordReversalTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("My name is X Y Z", "Z Y X is name My")]
        public void Test(string input, string expected)
        {
            var result = new WordReversal().Reverse(input);
            Assert.AreEqual(expected, result);
        }
    }

    public class WordReversal
    {
        public string Reverse(string input)
        {
            var words = input.Split(' ');
            var reversed = words.Reverse();
            return string.Join(' ', reversed);
        }
    }
}
