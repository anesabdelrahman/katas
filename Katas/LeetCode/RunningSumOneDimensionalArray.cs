namespace Katas.LeetCode
{
    public class RunningSumOneDimensionalArray
    {
        public int[] RunningSum(int[] nums)
        {
            var currentValue = 0;
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                currentValue += nums[i];
                result[i] = currentValue;
            }

            return result;
        }
    }
}
