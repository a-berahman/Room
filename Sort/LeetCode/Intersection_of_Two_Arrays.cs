
using System.Collections.Generic;

namespace Sort.LeetCode
{
    public class Intersection_of_Two_Arrays

    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var first = new List<int>();
            var second = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (first.Contains(nums1[i]))
                {
                    continue;
                }
                else first.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (second.Contains(nums2[i]))
                {
                    continue;
                }
                else second.Add(nums2[i]);
            }

            var result = new List<int>();
            for (int i = 0; i < first.Count; i++)
            {
                if (second.Contains(first[i]))
                    result.Add(first[i]);
            }
            return result.ToArray();
        }
    }
}