using System;
using System.Linq;

namespace Katas
{
    public class ValidMountainArray
    {
        //Initial version:
        // Time complexity O(n)
        // Space complexity O(1)

        public bool ValidMountain_Initial(int[] arr)
        {
            bool asc = false, desc = false;

            if (arr.Length < 3)
                return false;

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    if (!desc)
                    {
                        asc = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (arr[i] < arr[i - 1])
                {
                    if (asc)
                    {
                        desc = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return asc && desc;
        }


        //Modified version: 
        // Time complexity O(n)
        // Space complexity O(1)

        public bool ValidMountain_Modified(int[] arr)
        {

            if (arr.Length < 3)
                return false;

            var i = 0;

            while (i < arr.Length - 1 && arr[i] < arr[i + 1])
            {
                i++;
            }

            if (i == 0 || i == arr.Length - 1)
            {
                return false;
            }

            while (i < arr.Length - 1 && arr[i] > arr[i + 1])
            {
                i++;
            }

            return i == arr.Length - 1;
        }
    }
}
