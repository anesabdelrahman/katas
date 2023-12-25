using System;
using System.Linq;
using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class ArraySumTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 10, 11 }, 31)]
        public void Test(int[] arr, int expectedResult)
        {
            var sut = new SimpleArraySum();
            var result = sut.AddArrayElements(arr);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }
    }

    internal class SimpleArraySum
    {
        public SimpleArraySum()
        {
        }

        internal int AddArrayElements(int[] arr)
        {
            //var sum = 0;
            //foreach (var item in arr)
            //{
            //    sum += item;
            //}


            return arr.Sum();
        }
    }
}
