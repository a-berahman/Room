using System;

namespace Implementation.HackerRank
{
    public class Electronics_Shop
    {
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var max = -1;
            for (int i = 0; i < keyboards.Length; i++)
                for (int j = 0; j < drives.Length; j++)
                    if (keyboards[i] + drives[j] <= b)
                        max = Math.Max(max, keyboards[i] + drives[j]);
            return max;
        }

    }
}