using System.Collections.Generic;
using System;
using System.Linq;

namespace Recursion_and_Backtracking.LeetCode
{
    //Back Track
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var _outPut = new List<IList<int>>();
            BackTrack(nums.Length, nums, ref _outPut, 0);
            return _outPut;
        }

        private void BackTrack(int length, int[] nums, ref List<IList<int>> outPut, int first)
        {
            if (length == first) outPut.Add(nums.ToList());
            for (int i = first; i < length; i++)
            {
                Swap(nums, i, first);
                BackTrack(length, nums, ref outPut, first + 1);
                Swap(nums, i, first);
            }
        }
        private void Swap(int[] nums, int p, int q)
        {
            var temp = nums[p];
            nums[p] = nums[q];
            nums[q] = temp;
        }
    }
}