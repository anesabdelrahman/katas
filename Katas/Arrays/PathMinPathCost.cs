using System;

namespace Katas.Arrays;

public class PathMinPathCost
{
    public int CalculatePathCost(int[] array)
    {
        var maxCost = 0;

        for (var i = 0; i < array.Length - 2; i++)
        {
            var currentCost = Math.Abs(array[i + 2] - array[i]);
            maxCost = Math.Max(maxCost, currentCost);
        }

        return maxCost;
    }
}


//index value
//0     5
//1     4
//2     2
