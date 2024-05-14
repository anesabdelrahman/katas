using System;
using System.Linq;

namespace Katas
{
    public class ArrayRemoveElements
    {
        //Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.

        //    Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

        //Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
        //    Return k.


        public int RemoveElement_Not_Efficient(int[] nums, int val)
        {
            
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = 0;
                }
            }

            var result = nums.ToList();
            result.RemoveAll(x => x == 0);
            
            return result.Count;
        }
        public int RemoveElement_Efficient(int[] nums, int val)
        {
            var length = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                
                if (nums[i] != val)
                {
                    nums[length] = nums[i];
                    length++;
                }
            }
            
            return length;
        }
    }
}
