using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/range-sum-query-immutable/description/
    [TestFixture(Category = "Leetcode", Reason = "Prefix sum")]
    internal class FindingProductOfElementsButSelfTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[]{ 24, 12, 8, 6 })]
        [TestCase(new int[] { -1, 1, 0, -3, 3 }, new int[]{ 0, 0, 9, 0, 0 })]
        public void GetTheIndecies(int[] input, int[] expected)
        {
            var sut = new FindingProductOfElementsButSelf();
            var result = sut.SumOddLengthSubarrays(input);

            Assert.AreEqual(expected, result);
        }
    }

    internal class FindingProductOfElementsButSelf
    {
        public int[] SumOddLengthSubarrays(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];

            result[0] = 1;
            for (var i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            var suffixProduct = 1;
            for (var i = n - 1; i >= 0; i--)
            {
                result[i] *= suffixProduct; 
                suffixProduct *= nums[i]; 
            }

            return result;
        }
    }
}
