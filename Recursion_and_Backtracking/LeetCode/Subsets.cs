using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_and_Backtracking.LeetCode
{
    //Back Track
    public class SubSets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            Array.Sort(nums);
            var res = new List<IList< int>>();
            var solution = new List< int>();            
            SubsetsRecursion(nums, 0, res, solution);
            return res;
        }

        private void SubsetsRecursion(int[] nums, int index, List<IList<int>> res, List<int> solution)
        {
            if (index >= nums.Count())
            {
                res.Add(new List< int>(solution));
                return;
            }

            // add item nums[index] 
            solution.Add(nums[index]);
            this.SubsetsRecursion(nums, index + 1, res, solution);
            solution.RemoveAt(solution.Count - 1);

            // do not add nums[index]
            this.SubsetsRecursion(nums, index + 1, res, solution);
        }
    }
}