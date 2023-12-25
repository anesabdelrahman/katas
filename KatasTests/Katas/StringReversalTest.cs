using System;
using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class StringReversalTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("sena", "anes")]
        [TestCase("rat", "tar")]
        public void Test(string input, string expected)
        {
            var result = new StringReversal().Reverse(input);
            Assert.AreEqual(expected, result);
        }
    }
}
