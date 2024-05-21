using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class PathMinPathCostTest
    {
        [Test]
        //[TestCase(new[] { 1, 3, 5, 8, 12 }, 7)]
        [TestCase(new[] { 0, 2, 5, 6, 7 }, 5)]
        //[TestCase(new[] { 0, 3, 9 }, 9)]
        public void CalculatePathCost(int[] input, int expected)
        {
            var result = new PathMinPathCost().CalculatePathCost(input);
            Assert.AreEqual(expected, result);
        }
    }
}
