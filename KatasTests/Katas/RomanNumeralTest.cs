using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("1", "I")]
        [TestCase("2", "II")]
        [TestCase("3", "III")]
        [TestCase("4", "IV")]
        [TestCase("1000", "M")]
        [TestCase("47", "XLVII")]
        [TestCase("1990", "MCMXC")]
        [TestCase("2008", "MMVIII")]
        [TestCase("99", "XCIX")]
        public void Test(string input, string expected)
        {
            var sut = new RomanNumeral();
            var result = sut.GetRomanNumeral(input);

            Assert.AreEqual(result, expected);
        }
    }
}
