using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/contiguous-array/description/
    [TestFixture(Category = "Leetcode")]
    internal class FindingContiguousSubArraysOfEqualZerosAndOnesTest
    {

        [Test]
        [TestCase(new int[] { 0,1 }, 2)]
        [TestCase(new int[] { 0,1,0 }, 2)]
        public void GetTheSumOfSubArrays(int[] input, int expectedSum)
        {
            var sut = new ContiguousSubArraysOfEqualZerosAndOnes();
            var result = sut.FindMaxLength(input);

            Assert.AreEqual(expectedSum, result);
        }
    }

    internal class ContiguousSubArraysOfEqualZerosAndOnes
    {
        
        public int FindMaxLength(int[] nums)
        {
            var maxLength = 0;
            var currentSum = 0;
            var prefixSumIndex = new Dictionary<int, int> {[0] = -1};
            // Iterate through the array
            for (var i = 0; i < nums.Length; i++)
            {
                currentSum += (nums[i] == 0) ? -1 : 1;

                // Check if we have seen this prefix sum before
                if (prefixSumIndex.ContainsKey(currentSum))
                {
                    // Calculate the length of the subarray
                    var length = i - prefixSumIndex[currentSum];
                    // Update the maximum length
                    maxLength = Math.Max(maxLength, length);
                }
                else
                {
                    // Store the first occurrence of this prefix sum
                    prefixSumIndex[currentSum] = i;
                }
            }

            return maxLength;

        }
    }
}
