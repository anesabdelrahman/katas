using System.Linq;

namespace Katas.LeetCode
{
    public class RichestWealth
    {
        //LONG-WINDED VERSION
        public int MaximumWealth1(int[][] accounts)
        {
            var max = 0;
            foreach (var item in accounts)
            {
                var sum = item.Sum();
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;
        }

        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Select(item => item.Sum()).Max();
        }
    }
}
