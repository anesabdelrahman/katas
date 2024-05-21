using System.Collections.Generic;
using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class MatchingSocksTest
    {

        [Test]
        public void Test()
        {
            var numberOfSocks = 7;
            var socksColors = new List<int> { 1, 2, 1, 2, 1, 3, 2 };
            var expectedResult = 2;

            var sut = new MatchingSocks();
            var result = sut.GetMatchingSocks(numberOfSocks, socksColors);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Test2()
        {
            var numberOfSocks = 10;
            var socksColors = new List<int> { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            var expectedResult = 4;

            var sut = new MatchingSocks();
            var result = sut.GetMatchingSocks(numberOfSocks, socksColors);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }


        [Test]
        public void Test3()
        {
            var numberOfSocks = 9;
            var socksColors = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            var expectedResult = 3;

            var sut = new MatchingSocks();
            var result = sut.GetMatchingSocks(numberOfSocks, socksColors);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }
    }
}
