using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/range-sum-query-immutable/description/
    [TestFixture(Category = "Leetcode", Reason = "Two Sum")]
    internal class FindingIndeciesOfElementsMakingUpSumOfTargetTest
    {

        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new[]{0,1})]
        [TestCase(new int[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void GetTheIndecies(int[] input, int target, int[] expected)
        {
            var sut = new FindingIndeciesOfElementsMakingUpSumOfTarget();
            var result = sut.GetIndecies_Efficient(input, target);

            Assert.AreEqual(expected, result);
        }
    }

    internal class FindingIndeciesOfElementsMakingUpSumOfTarget
    {
        public int[] GetIndecies_BruteForce(int[] input, int target)
        {
            var result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == target)
                    {
                        return [i, j];
                    }
                }
            }

            return result;
        }

        // Two Sum algorithm
        public int[] GetIndecies_Efficient(int[] input, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (map.ContainsKey(target - input[i]))
                {
                    var item = map[target-input[i]];
                    ;
                    return [item, i];
                }
                map.Add(input[i],i);
            }

            return null;
        }
    }
}
