using System.Collections.Concurrent;
using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/subarray-sum-equals-k/description/
    [TestFixture(Category = "Leetcode")]
    internal class FindingSumOfSubArraysUsingKthElementTest
    {

        [Test]
        [TestCase(new int[] { 1,1,1 }, 2,  2)]
        [TestCase(new int[] { 1,2,3 }, 3,  2)]
        public void GetTheSumOfSubArrays(int[] input, int kElement, int expectedSum)
        {
            var sut = new FindingSumOfSubArraysUsingKthElement();
            var result = sut.GetTheSumOfSubArrays(input, kElement);

            Assert.AreEqual(expectedSum, result);
        }
    }

    internal class FindingSumOfSubArraysUsingKthElement
    {
        public int GetTheSumOfSubArrays(int[] input, int k)
        {
            var count = 0;
            var currentSum = 0;
            var prefixSums = new Dictionary<int, int>() {{0, 1}};

            foreach (var item in input)
            {
                currentSum += item;

                int lookupKe = currentSum - k;

                if (prefixSums.ContainsKey(lookupKe))
                {
                    count += prefixSums[lookupKe];
                }

                if (prefixSums.ContainsKey(currentSum))
                {
                    prefixSums[currentSum]++;
                }
                else
                {
                    prefixSums[currentSum] = 1;
                }
            }
            
            return count;
        }
    }
}
