using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class ArrayRemoveElementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 3, 2, 2, 3 }, 3, 2)]
        public void Test_Not_Efficiently(int[] arr, int target, int expectedResult)
        {
            var sut = new ArrayRemoveElements();
            var result = sut.RemoveElement_Not_Efficient(arr, target);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase(new int[] { 3, 2, 2, 3 }, 3, 2)]
        public void Test_Efficiently(int[] arr, int target, int expectedResult)
        {
            var sut = new ArrayRemoveElements();
            var result = sut.RemoveElement_Efficient(arr, target);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
