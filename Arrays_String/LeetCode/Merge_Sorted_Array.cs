using System;

namespace Arrays_String.LeetCode
{
    public class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var aindex = m - 1;
            var bindex = n - 1;
            while (aindex >= 0 || bindex >= 0)
            {
                var avalue = aindex >= 0 ? nums1[aindex] : int.MinValue;
                var bvalue = bindex >= 0 ? nums2[bindex] : int.MinValue;

                if (avalue > bvalue)
                {
                    nums1[aindex + bindex + 1] = avalue;
                    aindex--;
                }
                else
                {
                    nums1[aindex + bindex + 1] = bvalue;
                    bindex--;
                }
            }

            // int j = 0;

            // var _condition = m < n ? nums2.Length : n;

            // for (int i = 0; i < nums1.Length; i++)
            // {
            //     if (nums1[i] == 0 && j < _condition)
            //     {
            //         nums1[i] = nums2[j];
            //         j++;
            //     }
            // }

            // Array.Sort(nums1);
        }
    }
}
