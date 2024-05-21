using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class ArrayChunkTest
    {
        [Test]
        public void TestOne()
        {
            var input = new[] { 1, 2, 3 };
            var size = 1;
            var expected = new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } };
            var result = new ArrayChunk().Chunk(input, size);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestTwo()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var size = 2;
            var expected = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 9, 10 } };
            var result = new ArrayChunk().Chunk(input, size);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestThree()
        {
            var input = new[] { 1, 2, 3, 4, 5 };
            var size = 3;
            var expected = new[] { new[] { 1, 2, 3 }, new[] { 4, 5 } };
            var result = new ArrayChunk().Chunk(input, size);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFour()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var size = 5;
            var expected = new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 }, new[] { 11, 12, 13 } };
            var result = new ArrayChunk().Chunk(input, size);
            Assert.AreEqual(expected, result);
        }

    }
}
