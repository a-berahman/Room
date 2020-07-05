using System;
using System.Collections.Generic;

namespace Implementation.HackerRank
{
    public class Picking_Numbers
    {
        public int pickingNumbers(List<int> a)
        {

            var frequency = new int[101];

            var max = int.MinValue;

            for (int i = 0; i < a.Count; i++)
                frequency[a[i]]++;


            for (int i = 1; i <= 100; i++)
                max = Math.Max(max, frequency[i] + frequency[i - 1]);
            return max;
        }
    }
}