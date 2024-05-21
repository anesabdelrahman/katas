using Katas.Strings;
using NUnit.Framework;

namespace Tests.Katas.Strings
{
    [TestFixture]
    public class MostRepeatedCharacterTest
    {
        [Test]
        [TestCase("aaaabbbbbbbaa", 'b', 7)]
        public void Test2(string input, char letter, int count)
        {
            var result = MostRepeatedCharacter.LongestRepetitionTwo(input);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result.Item1, letter);
            Assert.AreEqual(result.Item2, count);
        }

    }
}
