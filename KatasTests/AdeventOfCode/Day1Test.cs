using AdventOfCode;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class Day1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("1abc2", 3)]
        [TestCase("pqr3stu8vwx", 11)]
        [TestCase("a1b2c3d4e5f", 6)]
        [TestCase("treb7uchet", 14)]
        [TestCase("51591twosix4dhsxvgghxq", 9)]
        [TestCase("425nine", 9)]
        [TestCase("llvmhjtr8nbbhrfone", 16)]
        public void Test(string input, int expected)
        {
            var sut = new Day1();
            var result = sut.CalculateCodes(input);

            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestWithInputFile()
        {
            var sut = new Day1();
            
            var result = sut.ReadFileContents(".\\Files/Day1_Input.txt");

            Assert.AreEqual(result, 10100);
        }

    }
}
