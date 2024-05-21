namespace Katas.Arrays
{
    public class BinarySearch
    {
        public int Search(int[] sortedArray, int target)
        {
            var left = 0;
            var right = sortedArray.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (sortedArray[mid] == target)
                    return sortedArray[mid];

                if (sortedArray[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
