using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_String.HackerRank
{
    public class Missing_Numbers
    {
        public int[] missingNumbers(int[] arr, int[] brr)
        {
            Array.Sort(arr);
            Array.Sort(brr);
            var missList=new HashSet<int>();
            int i=0, j = 0;
            while (i < arr.Length && j < brr.Length)
            {
                while(brr[j]!=arr[i])
                {
                    missList.Add(brr[j]);
                    j++;
                }
                i++;
                j++;
            }
            while(j<brr.Length)
            {
                missList.Add(brr[j]);
                    j++;
            }
            var res=missList.ToArray();
            Array.Sort(res);
            return res;
        }

    }
}