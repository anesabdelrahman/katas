using NUnit.Framework;

namespace Tests.Katas
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
}
