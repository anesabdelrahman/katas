using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class ReplaceWithGreatestElementToRightTest
    {
        [Test]
        [TestCase(new[] { 17, 18, 5, 4, 6, 1 }, new[] { 18, 6, 6, 6, 1, -1 })]
        [TestCase(new[] { 400 }, new[] { -1 })]

        public void ReplaceElements(int[] input, int[] expected)
        {
            var result = new ReplaceWithGreatestElementToRight().ReplaceElements_Efficient(input);
            Assert.AreEqual(expected, result);
        }
    }
}
