using System;
using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class AnagramTest
    {
        [Test]
        [TestCase("danger", "garden", true)]
        [TestCase("danger", "Garden", false)]
        [TestCase("danger", "garden ", false)]
        [TestCase("danger", "garde", false)]
        [TestCase("danger", "gardenn", false)]
        public void Test_Using_List_Inefficient(string first, string second, bool expected)
        {
            var sut = new Anagram();
            var result = sut.IsAnagramUsingLists(first, second );
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expected);
        }
        
        [Test]
        [TestCase("danger", "garden", true)]
        [TestCase("danger", "Garden", false)]
        [TestCase("danger", "garden ", false)]
        [TestCase("danger", "garde", false)]
        [TestCase("danger", "gardenn", false)]
        public void Test_Using_Dictionary_Efficient(string first, string second, bool expected)
        {
            var sut = new Anagram();
            var result = sut.IsAnagramUsingDictionary(first, second );
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expected);
        }
    }
}
