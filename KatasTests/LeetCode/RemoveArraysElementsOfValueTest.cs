using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class RemoveArraysElementsOfValueTest
    {
        [Test]
        [TestCase(new[] { 3, 2, 2, 3 }, 3, 2)]
        public void Test(int[] input, int value, int expected)
        {
            var sut = new RemoveArraysElementsOfValue();
            var result = sut.RemoveElement(input, value);
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expected);
        }
    }

    public class RemoveArraysElementsOfValue
    {
        public int RemoveElement(int[] nums, int val)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val) continue;
                nums[result] = nums[i];
                result++;
            }

            return result;
        }
    }
}
