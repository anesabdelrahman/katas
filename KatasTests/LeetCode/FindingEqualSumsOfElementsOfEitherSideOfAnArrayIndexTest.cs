using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture(Category = "Leetcode", Reason = "Prefix sums")]
    internal class FindingEqualSumsOfElementsOfEitherSideOfAnArrayIndexTest
    {
        [Test]
        [TestCase(new[] { 7, 2, 1, 5, 4 },   "2")]
        [TestCase(new[] { 23, 32, 12, 4 },  "No Equilibrium")]
        public void GetTheSumOfSubArrays(int[] input, string expectedSum)
        {
            var sut = new FindingEqualSumsOfElementsOfEitherSideOfAnArrayIndex();
            var result = sut.GetTheSumOfSubArrays(input);

            Assert.AreEqual(expectedSum, result);
        }
    }

    internal class FindingEqualSumsOfElementsOfEitherSideOfAnArrayIndex
    {
        public string GetTheSumOfSubArrays(int[] input)
        {
            var currentSum = 0;
            var sums = new int[input.Length];

            for (var i =0; i < input.Length; i++)
            {
                currentSum += input[i];
                sums[i] = currentSum;
            }

            for (var i = 0; i < input.Length; i++)
            {
                if (i == 0 || i == input.Length - 1)
                {
                    continue;
                }

                if (sums[i - 1] == sums[^1] - sums[i])
                {
                    return i.ToString();
                }
            }
            return "No Equilibrium";
        }
    }
}
