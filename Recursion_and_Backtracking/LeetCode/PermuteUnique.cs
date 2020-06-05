using System.Collections.Generic;
using System;
using System.Linq;

namespace Recursion_and_Backtracking.LeetCode
{
    //Back Track
    public class Permutations_II
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            var res = new List<IList<int>>();
            this.PermuteUniqueHelper(nums, 0, res);
            return res;
        }

        private void PermuteUniqueHelper(int[] nums, int index, List<IList<int>> res)
        {
            var used = new Dictionary<int, bool>();
            if (index == nums.Length)
            {
                res.Add(new List<int>(nums));
                return;
            }

            for (int i = index; i < nums.Length; i++)
            {
                if (!used.ContainsKey(nums[i]))
                {
                    Swap(nums, i, index);
                    this.PermuteUniqueHelper(nums, index + 1, res);
                    Swap(nums, i, index);

                    used.Add(nums[i], true);
                }
            }
        }
        private void Swap(int[] nums, int p, int q)
        {
            var _copy = nums[p];
            nums[p] = nums[q];
            nums[q] = _copy;
        }
    }
}