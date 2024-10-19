using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/range-sum-query-immutable/description/
    [TestFixture(Category = "Leetcode", Reason = "Prefix sums")]
    internal class FindingSumOfSubArraysUsingIndicesRangeTest
    {

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1, 3, 9)]
        public void GetTheSumOfSubArrays(int[] input, int firstIndex, int secondIndex, int expectedSum)
        {
            var sut = new FindingSumOfSubArraysUsingIndicesRange();
            var result = sut.GetTheSumOfSubArrays(input, firstIndex, secondIndex);

            Assert.AreEqual(expectedSum, result);
        }
    }

    internal class FindingSumOfSubArraysUsingIndicesRange
    {
        public int GetTheSumOfSubArrays_Standard(int[] input, int firstIndex, int secondIndex)
        {
            var result = 0;
            if (firstIndex < input?.Length && secondIndex < input?.Length)
                for (var i = firstIndex; i <= secondIndex; i++)
                    result += input[i];

            return result;
        }

        public int GetTheSumOfSubArrays(int[] input, int firstIndex, int secondIndex)
        {
            var result = 0;
            var sumArray = new int[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    sumArray[i] = input[i];
                    continue;
                }
                sumArray[i] = sumArray[i - 1] + input[i];
            }


            return sumArray[secondIndex] - sumArray[firstIndex - 1];
        }
    }
}
