﻿using Katas.LeetCode;
using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class RunningSumOneDimensionalArrayTest
    {
        /// <summary>
        /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

        //Return the running sum of nums.

        //Input: nums = [1, 2, 3, 4]
        //Output: [1,3,6,10]

        //Input: nums = [1, 1, 1, 1, 1]
        //Output: [1,2,3,4,5]

        //Input: nums = [3, 1, 2, 10, 1]
        //Output: [3,4,6,16,17]
        /// </summary>

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void Test(int[] input, int[] expected)
        {
            var sut = new RunningSumOneDimensionalArray();
            var result = sut.RunningSum(input);
            Assert.AreEqual(result, expected);
        }

    }
}
