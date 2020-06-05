using System;
namespace Arrays_string.LeetCode
{
    public class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {

            for (int lastNonZeroFoundAt = 0, cur = 0; cur < nums.Length; cur++)
            {
                if (nums[cur] != 0)
                {
                    Swap(nums, lastNonZeroFoundAt++, cur);
                }
            }
            Console.WriteLine($"[{string.Join(",", nums)}]");

        }

        private void Swap(int[] nums, int p, int q)
        {
            var _copy = nums[p];
            nums[p] = nums[q];
            nums[q] = _copy;
        }
    }
}