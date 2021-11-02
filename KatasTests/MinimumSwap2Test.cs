using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class MinimumSwap2Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 4, 3, 1, 2 }, 3)]
        [TestCase(new int[] { 2, 3, 4, 1, 5 }, 3)]
        [TestCase(new int[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
        public void Test(int[] input, int expected)
        {
            var sut = new MinimumSwaps2();
            var result = sut.GetminimumSwaps(input);

            Assert.AreEqual(result, expected);
        }
    }
}
