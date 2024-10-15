using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class MoveZerosToEndOfArrayTest
    {
        [Test]
        [TestCase(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
        [TestCase(new[] { 1, 0 }, new[] { 1, 0 })]
        [TestCase(new[] { 1, 0, 0 }, new[] { 1, 0, 0 })]
        [TestCase(new[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 }, new[] { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 })]

        public void MoveZerosTest(int[] input, int[] expected)
        {
            var result = new MoveZerosToEndOfArray().MoveZeros(input);
            
            foreach (var item in result)
            {
                TestContext.Write($"{item} ,");
            }

            Assert.AreEqual(expected, result);
        }
    }

    public class MoveZerosToEndOfArray
    {
        public int[] MoveZeros(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 || i == nums.Length -1) continue;

                var jumpToIndex = i + 1;
                while (jumpToIndex < nums.Length)
                {
                    if (nums[jumpToIndex] != 0)
                    {
                        (nums[jumpToIndex], nums[i]) = (nums[i], nums[jumpToIndex]);
                        break;
                    }
                    jumpToIndex++;
                }
                
            }

            return nums;
        }
    }
}
