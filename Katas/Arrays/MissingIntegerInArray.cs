using System;

namespace Katas.Arrays;

public class MissingIntegerInArray
{
    public int CalculateMissingInteger(int[] A)
    {
        if (A == null || A.Length == 0)
            return 1;

        Array.Sort(A);

        if (A[0] > 1)
            return 1;

        for (var i = 1; i < A.Length; i++)
        {
            if (A[i] == A[i - 1])
                continue;

            // If there's a gap greater than 1 between consecutive elements
            if (A[i] <= A[i - 1] + 1) continue;
            if (A[i - 1] + 1 > 0)
                return A[i - 1] + 1;
        }
        return A[^1] + 1 > 0 ? A[^1] + 1 : 1;
    }
}
