using Katas.Arrays;
using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class MergeSortTwoArraysTest
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 0, 0, 0 }, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, new[] { 1, 2, 2 }, 6,  new[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
        public void Test(int[] nums1, int[] nums2,int firstNumsLength, int[] expected)
        {
            var sut = new MergeSortTwoArrays();
            var result = sut.MergeSort(nums1, nums2, firstNumsLength);
            foreach (var item in result)
            {
                TestContext.Write($"{item}, ");
            }
            Assert.AreEqual(result, expected);
        }
    }
}
