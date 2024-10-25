using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/range-sum-query-immutable/description/
    [TestFixture(Category = "Leetcode", Reason = "Two Sum")]
    internal class FindingSumOfAllOddSubArraysTest
    {

        [Test]
        [TestCase(new int[] { 1, 4, 2, 5, 3 }, 58)]
        [TestCase(new int[] { 3, 2, 4 }, 18)]
        [TestCase(new int[] { 3, 3 }, 6)]
        public void GetTheIndecies(int[] input, int expected)
        {
            var sut = new FindingSumOfAllOddSubArrays();
            var result = sut.SumOddLengthSubarrays(input);

            Assert.AreEqual(expected, result);
        }
    }

    internal class FindingSumOfAllOddSubArrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            var totalSum = 0;
            for (int start = 0; start < arr.Length; start++)
            {
                // Iterate over odd-length subarrays starting at 'start'
                for (int length = 1; start + length <= arr.Length; length += 2)
                {
                    // Calculate the sum of the subarray arr[start...start+length-1]
                    for (int i = start; i < start + length; i++)
                    {
                        totalSum += arr[i];
                    }
                }
            }

            return totalSum;
        }

       
    }
}
