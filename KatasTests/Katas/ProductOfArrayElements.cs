using NUnit.Framework;

namespace Tests.Katas
{
    [TestFixture]
    public class ProductOfArrayElements
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [TestCase(new[] { 1, 0, 3, 4 }, new[] { 0, 12, 0, 0 })]
        [TestCase(new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 })]
        [TestCase(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        public void CalculateProductOfArrayElements(int[] input, int[] expected)
        {
            var result = new ArrayElements().CalculateProductOfElements(input);
            Assert.AreEqual(expected, result);
        }
    }
}
