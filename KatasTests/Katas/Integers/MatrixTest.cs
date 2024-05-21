using Katas;
using Katas.Integers;
using NUnit.Framework;

namespace Tests.Katas.Integers
{
    [TestFixture]
    public class MatrixTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Input_Two()
        {
            var sut = new Matrix();
            var input = 2;
            var expected = new[] { new[] { 1, 2 }, new[] { 4, 3 } };
            var result = sut.FillMatrix(input);
            Assert.AreEqual(result.Length, input);
            Assert.AreEqual(result[0], new[] { 1, 2 });
            Assert.AreEqual(result[1], new[] { 4, 3 });
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Test_Input_Three()
        {
            var sut = new Matrix();
            var input = 3;
            var expected = new[] { new[] { 1, 2, 3 }, new[] { 8, 9, 4 }, new[] { 7, 6, 5 } };
            var result = sut.FillMatrix(input);
            Assert.AreEqual(result.Length, input);
            Assert.AreEqual(result[0], new[] { 1, 2, 3 });
            Assert.AreEqual(result[1], new[] { 8, 9, 4 });
            Assert.AreEqual(result[2], new[] { 7, 6, 5 });
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Test_Input_Four()
        {
            var sut = new Matrix();
            var input = 4;
            var expected = new[] { new[] { 1, 2, 3, 4 }, new[] { 12, 13, 14, 5 }, new[] { 11, 16, 15, 6 }, new[] { 10, 9, 8, 7 } };
            var result = sut.FillMatrix(input);
            Assert.AreEqual(result.Length, input);
            Assert.AreEqual(result[0], new[] { 1, 2, 3, 4 });
            Assert.AreEqual(result[1], new[] { 12, 13, 14, 5 });
            Assert.AreEqual(result[2], new[] { 11, 16, 15, 6 });
            Assert.AreEqual(result[3], new[] { 10, 9, 8, 7 });
            Assert.AreEqual(expected, result);

        }
    }
}
