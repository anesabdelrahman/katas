using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class VowelsTest
    {
        private Vowels sut;

        [SetUp]
        public void Setup()
        {
            sut = new Vowels();
        }

        [Test]
        [TestCase("aeiou", 5)]
        [TestCase("AEIOU", 5)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", 5)]
        [TestCase("bcdfghjkl", 0)]
        public void Test(string input, int expected)
        {
            var result = sut.CountVowels(input);
            Assert.AreEqual(expected, result);
        }
    }
}
