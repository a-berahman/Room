using System;
using System.Collections.Generic;

namespace Arrays_String.LeetCode
{
    public class Interval_List_Intersections
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            List<int[]> ans = new List<int[]>();
            int i = 0, j = 0;

            while (i < A.Length && j < B.Length)
            {
                // Let's check if A[i] intersects B[j].
                // lo - the startpoint of the intersection
                // hi - the endpoint of the intersection
                int lo = Math.Max(A[i][0], B[j][0]);
                int hi = Math.Min(A[i][1], B[j][1]);

                if (lo <= hi)
                    ans.Add(new int[] { lo, hi });

                // Remove the interval with the smallest endpoint
                if (A[i][1] < B[j][1])
                    i++;
                else
                    j++;
            }

            return ans.ToArray();
        }
    }
}