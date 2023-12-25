namespace Katas
{
    public class MinimumSwaps2
    {
        public int GetminimumSwaps(int[] arr)
        {
            int count = 0;
            int i = 0;

            while (i < arr.Length)
            {
                int index = arr[i] - 1;
                if (arr[i] != arr[index])
                {
                    var temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    count++;
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
    }
}
