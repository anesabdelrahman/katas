namespace Katas.Arrays;

public class ReplaceWithGreatestElementToRight
{
    /*
     * Given an array arr, replace every element in that array with the greatest element among the elements to its right,
     * and replace the last element with -1. After doing so, return the array.
     */
    public int[] ReplaceElements(int[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            var j = i + 1;
            var largest = 0;
            while (j < arr.Length)
            {
                if (arr[j] > largest)
                    largest = arr[j];
                j++;
            }

            arr[i] = largest;
        }

        arr[^1] = -1;

        return arr;

        // Runtime: 814 ms
        // Memory Usage: 93.9 MB
    }

    public int[] ReplaceElements_Efficient(int[] arr)
    {
        var largest = arr[^1];
        arr[^1] = -1;
        for (var i = arr.Length - 2; i >= 0; i--)
        {
            var helper = arr[i];
            arr[i] = largest;
            if (helper > largest)
                largest = helper;

        }
        return arr;

        // Runtime: 279 ms
    }
}
