using Katas;
using Katas.Strings;
using NUnit.Framework;

namespace Tests.Katas.Strings
{
    [TestFixture]
    public class StringAnagramTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("hello#@", "llohe", true)]
        [TestCase("Whoa! Hi!", "Hi! Whoa!", true)]
        [TestCase("One One", "Two two two", false)]
        [TestCase("One one", "One one c", false)]
        [TestCase("A tree, a life, a bench", "A tree, a fence, a yard", false)]
        public void Test(string firstString, string secondString, bool expected)
        {
            var result = new StringAnagram().IsAnagram(firstString, secondString);
            Assert.AreEqual(expected, result);
        }
    }
}
