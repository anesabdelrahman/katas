using System;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/range-sum-query-immutable/description/
    [TestFixture(Category = "Leetcode", Reason = "Prefix sum")]
    internal class FindingLongestSubsequenceWithLimitedSumTest
    {
        [Test]
        [TestCase(new int[] { 4, 5, 2, 1 }, new[]{ 3, 10, 21 }, new[] { 2, 3, 4 })]
        [TestCase(new int[] { 2, 3, 4, 5 }, new[]{ 1 }, new[] { 0 })]
        public void GetTheIndecies(int[] input, int[] query, int[] expected)
        {
            var sut = new FindingLongestSubsequenceWithLimitedSum();
            var result = sut.AnswerQueries(input, query);

            Assert.AreEqual(expected, result);
        }
    }

    internal class FindingLongestSubsequenceWithLimitedSum
    {
        public int[] AnswerQueries(int[] input, int[] query)
        {
            var result = new int[query.Length];
            var sums = new int[input.Length];
            Array.Sort(input);
            sums[0] = input[0];
            for (var i = 1; i < input.Length; i++)
            {
                sums[i] = sums[i-1] + input[i];
            }

            for (var i = 0; i < query.Length; i++)
            {
                var index = Array.BinarySearch(sums, query[i]);

                if (index < 0)
                {
                    index = ~index;
                }
                else
                {
                    index++;
                }
                result[i] = index;
            }

            return result;
        }
    }
}
