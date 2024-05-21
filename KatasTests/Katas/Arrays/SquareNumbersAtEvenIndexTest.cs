using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class SquareNumbersAtEvenIndexTest
    {
        [Test]
        [TestCase(new int[] { 9, -2, -9, 11, 56, -12, -3 }, new int[] { 81, -2, 81, 11, 3136, -12, 9 })]

        public void SquareValuesAtEvenIndex(int[] input, int[] expected)
        {
            var result = new SquareNumbersAtEvenIndex().SequareEvenIndex(input);
            Assert.AreEqual(expected, result);
        }
    }
}
