using System;
using System.Collections.Generic;

namespace Implementation.HackerRank
{
    public class Birthday_Chocolate
    {
        public int birthday(List<int> s, int d, int m)
        {
            var res = 0;
            // check 3 condtion that, if each one of them happens we should return 0
            if (m == 0 || s.Count == 0 || s.Count < m)
                return res;

            // define variables
            var arr = s.ToArray();
            
            //for avoid of duplicate
            var dic = new HashSet<string>();
            var key = string.Empty;

            //maintain sum of three elemnet
            var sum = 0;
            
            int count = 0;

            for (int i = 0, j = 0; j < arr.Length; )
            {

                sum += arr[j];
                //generate key for maintain on dic variable
                key += arr[j].ToString() + ",";
                //i want to maintain count of element that whenever arrive to m value
                //checking the result for m elements sum
                count++;
                if (count == m)
                {
                    //check duplicate and sum is equals with d?
                    if (sum == d && !dic.Contains(key))
                    {
                        res++;
                        dic.Add(key);
                    }
                    count = 0;
                    //seting j to start point + 1
                    j = ++i;
                    key = "";
                    sum=0;
                } else j++;
            }

            return res;
        }
    }
}