using System;
using System.Linq;

namespace Sort.LeetCode
{
    public class Merge_Intervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals;
            var list = intervals.ToList();
            var starts = new int[intervals.Length];
            var ends = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                starts[i] = list[i][0];
                ends[i] = list[i][1];
            }

            Array.Sort(starts);
            Array.Sort(ends);

            list.Clear();
            var current = new int[] { starts[0], ends[0] };
            int j = 1;
            while (j < starts.Length)
            {
                if (current[1] >= starts[j])
                {
                    current[1] = ends[j];
                }
                else
                {
                    list.Add(current);
                    current = new int[] { starts[j], ends[j] };
                }
                j++;
            }
            list.Add(current);
            return list.ToArray();
        }
    }
}