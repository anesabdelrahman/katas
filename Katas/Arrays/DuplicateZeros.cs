using System;
using System.Linq;

namespace Katas.Arrays
{
    public class DuplicateZeros
    {
        public int[] DuplicateZero(int[] arr)
        {
            if (arr.All(x => x == 0))
                return arr;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != 0) continue;
                for (var j = arr.Length - 2; j > i; j--)
                    arr[j + 1] = arr[j];

                arr[i + 1] = 0;
                i += 1;
            }

            return arr;
        }
    }
}
