using System;
using System.Collections.Generic;

namespace Arrays_String.LeetCode
{
    public class Subarray_Sum_Equals_K
    {
        public int SubarraySum(int[] nums, int k)
        {

            var _count = 0;
            //first Approach
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     var _sum = 0;
            //     for (int j = i; j < nums.Length; j++)
            //     {
            //         _sum += nums[j];
            //         if (_sum == k)
            //         {
            //             _count++;
            //         }
            //     }
            // }

            //second approach
            var _sum = 0;
            var _dic = new Dictionary<int, int>();
            _dic.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                _sum += nums[i];
                if (_dic.ContainsKey(_sum - k))
                    _count += _dic[_sum - k];

                if (_dic.ContainsKey(_sum))
                    _dic[_sum]++;
                else
                    _dic.Add(_sum, 1);
            }

            return _count;
        }
    }
}