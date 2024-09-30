using Katas.LeetCode;
using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class DuplicateZeroTest
    {
        [Test]
        [TestCase(new[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new[] { 0, 4, 1, 0, 0, 8, 0, 0, 3 }, new[] { 0, 0, 4, 1, 0, 0, 0, 0, 8 })]
        [TestCase(new[] { 8, 4, 5, 0, 0, 0, 0, 7 }, new[] { 8, 4, 5, 0, 0, 0, 0, 0 })]
        public void Test(int[] input, int[] expected)
        {
            var sut = new DuplicateZeros();
            var result = sut.DuplicateZero_AntherWorkingVersion(input);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expected);
        }
    }
}
