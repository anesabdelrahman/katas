using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class PrimeFactorsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, new int[0])]
        [TestCase(2, new int[] { 2 })]
        [TestCase(3, new int[] { 3 })]
        [TestCase(4, new int[] { 2, 2 })]
        [TestCase(6, new int[] { 2, 3 })]
        [TestCase(8, new int[] { 2, 2, 2 })]
        [TestCase(9, new int[] { 3, 3 })]
        [TestCase(42, new int[] { 2, 3, 7 })]
        [TestCase(2 * 3 * 5 * 7 * 11 * 13, new int[] { 2, 3, 5, 7, 11, 13 })]
        [TestCase(int.MaxValue, new int[] { int.MaxValue })]
        public void Test(int number, int[] expectedFactors)
        {
            var sut = new PrimeFactor();
            var result = sut.GetPrimeFactors(number);
            Assert.AreEqual(result, expectedFactors);
        }
    }
}
