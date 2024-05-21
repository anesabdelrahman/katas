namespace Katas.Arrays
{
    public class MinimumSwaps2
    {
        public int GetminimumSwaps(int[] arr)
        {
            var count = 0;
            var i = 0;

            while (i < arr.Length)
            {
                var index = arr[i] - 1;
                if (arr[i] != arr[index])
                {
                    var temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    count++;
                }
                else
                    i++;
            }
            return count;
        }
    }
}
