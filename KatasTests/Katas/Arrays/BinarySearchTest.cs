using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class BinarySearchTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6, 6)]
        public void Test(int[] arr, int target, int expectedResult)
        {
            var sut = new BinarySearch();
            var result = sut.Search(arr, target);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }
    }
}
