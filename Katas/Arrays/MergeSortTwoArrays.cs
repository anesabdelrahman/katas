namespace Katas.Arrays
{
    public class MergeSortTwoArrays
    {
        public int[] MergeSort(int[] nums1, int[] nums2, int firstNumsLength)
        {
            var firstZeroIndex = firstNumsLength;
            foreach (var item in nums2)
            {
                for (var j = 0; j < nums1.Length; j++)
                {

                    if (j == firstZeroIndex)
                    {
                        nums1[firstZeroIndex] = item;
                        firstZeroIndex++;
                        break;
                    }

                    if (item >= nums1[j]) continue;
                    for (var k = nums1.Length - 1; k > j; k--)
                    {
                        nums1[k] = nums1[k - 1];

                    }
                    nums1[j] = item;
                    firstZeroIndex++;
                    break;
                }
            }
            return nums1;
        }
    }
}
