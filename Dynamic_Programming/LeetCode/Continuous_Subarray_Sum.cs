using System.Collections.Generic;

namespace Dynamic_Programming.LeetCode
{
    public class Continuous_Subarray_Sum
    {
        public bool CheckSubarraySum(int[] nums, int k) {
        int[] runningSum = new int[nums.Length];
        runningSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            runningSum[i] = runningSum[i - 1] + nums[i];

        for (int start = 0; start < nums.Length - 1; start++)
        {
            for (int end = start + 1; end < nums.Length; end++)
            {
                int subArraySum = runningSum[end] - runningSum[start] + nums[start];
                if (subArraySum == k || (k != 0 && subArraySum % k == 0))
                    return true;
            }
        }
        return false;
    }

//Time out
//     public bool CheckSubarraySum(int[] nums, int k) {
//         for (int start = 0; start < nums.Length-1; start++)
//         {
//             for (int end = start + 1; end < nums.Length; end++)
//             {
//                 int sum = 0;
//                 for (int i = start; i <= end; i++)
//                     sum += nums[i];

//                 if (sum == k || (k != 0 && sum % k == 0))
//                     return true;
//             }
//         }
//         return false;
//     }

    }
}