using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class ThirdMaxItemInArrayTest
    {
        [Test]
        [TestCase(new[] { 3, 2, 1 }, 1)]
        [TestCase(new[] { 1, 2 }, 2)]
        [TestCase(new[] { 2, 2, 3, 1 }, 1)]
        public void Test(int[] input, int expected)
        {
            var sut = new ThirdMaxItemInArray();
            var result = sut.ThirdMaxUsingHashset_More_Efficient(input);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expected);
        }
    }

    public class ThirdMaxItemInArray
    {
        public int ThirdMaxUsingLinqs_Less_Efficient(int[] nums)
        {
            var distinct = nums.Distinct().OrderByDescending(x => x).ToList();
            return distinct.Count > 2 ? distinct.Take(3).Last() : distinct.Max();
        }

        public int ThirdMaxUsingHashset_More_Efficient(int[] nums)
        {
            var max = int.MinValue;
            var distinctSet = new HashSet<int>();

            foreach (var item in nums)
            {
                distinctSet.Add(item);
                if (item >  max) max = item;
            }

            var distinctList = distinctSet.ToList();
            distinctList.Sort();
            return distinctSet.Count <= 2 ? max : distinctList[^3];
        }
    }
}
