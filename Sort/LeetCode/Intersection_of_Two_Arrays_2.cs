
using System.Collections.Generic;

namespace Sort.LeetCode
{
    public class Intersection_of_Two_Arrays_2
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var _dic = new Dictionary<int, int>();
            var _result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (_dic.ContainsKey(nums1[i]))
                    _dic[nums1[i]]++;
                else _dic.Add(nums1[i], 1);
            }

            foreach (var item in nums2)
            {
                if (_dic.ContainsKey(item) && _dic[item] > 0)
                {
                    _result.Add(item);
                    _dic[item]--;
                }
            }

            return _result.ToArray();
        }
    }
}