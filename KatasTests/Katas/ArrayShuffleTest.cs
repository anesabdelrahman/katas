using System;
using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class ArrayShuffleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            var lower = 1;
            var upper = 7;
            var sut = new ArrayShuffle();
            var result = sut.ShuffleArray(lower, upper);

            Assert.NotNull(result);
        }
    }
}
