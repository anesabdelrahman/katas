using Katas;
using Katas.Strings;
using NUnit.Framework;

namespace Tests.Katas.Strings
{
    [TestFixture]
    public class PalindromeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("ANA", true)]
        [TestCase("aaaa", true)]
        [TestCase("112211", true)]
        [TestCase("Home", false)]
        [TestCase("pennep", true)]
        [TestCase("Fish hsif", false)]
        public void Test(string input, bool expected)
        {
            var result = new Palindrome().IsPalindrome(input);
            Assert.AreEqual(expected, result);
        }
    }
}
