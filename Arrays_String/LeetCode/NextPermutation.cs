using System;

namespace Arrays_String.LeetCode
{
    public class NextPermiutation
    {
        public void NextPermutation(int[] nums)
        {
            //1,2,3=>1,3,2
            int i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                swap(nums, i, j);
            }
            reverse(nums, i + 1);
        }

        private void reverse(int[] nums, int start)
        {
            int i = start; int j = nums.Length - 1;
            while (i < j)
            {
                swap(nums, i, j);
                i++;
                j--;
            }
        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}