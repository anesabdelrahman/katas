using System.Linq;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class MoveOddsToEndOfArrayTest
    {
        [Test]
        [TestCase(new[] { 3, 1, 2, 4 }, new[] { 2,4,3,1 })]
        public void MoveZerosTest(int[] input, int[] expected)
        {
            var result = new MoveOddsToEndOfArray().MoveOdssToEnd(input);
            
            foreach (var item in result)
            {
                TestContext.Write($"{item} ,");
            }

            Assert.AreEqual(expected, result);
        }
    }

    public class MoveOddsToEndOfArray
    {
        public int[] MoveOdssToEnd(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if ((nums[i] > 0 && nums[i] % 2 == 0) || i == nums.Length - 1)
                    continue;
                
                var nextIndex = i + 1;
                while (nextIndex < nums.Length)
                {
                    if (nums[nextIndex] % 2 == 0)
                    {
                        (nums[i], nums[nextIndex]) = (nums[nextIndex], nums[i]);
                        break;
                    }
                    nextIndex++;
                }
            }
            return nums;
        }

        public int[] MoveOdssToEnd1(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if ((nums[i] > 0 && (nums[i] & 1) == 0) || i == nums.Length - 1)
                    continue;

                var nextIndex = i + 1;
                while (nextIndex < nums.Length)
                {
                    if ((nums[nextIndex] & 1) == 0)
                    {
                        (nums[i], nums[nextIndex]) = (nums[nextIndex], nums[i]);
                        break;
                    }
                    nextIndex++;
                }
            }
            return nums;
        }
    }
}
