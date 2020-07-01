using System.Collections.Generic;

namespace Implementation.HackerRank
{
    public class Divisible_Sum_Pairs
    {
        public int divisibleSumPairs(int n, int k, int[] ar) {
        int res=0;
        if(n<2)
        return res;

        
        var dic=new HashSet<string>();
        for(int i=0; i<n;i++)
        {
            for(int j=0; j<n;j++)
            {
                if(j!=i 
                && i<j 
                && ((ar[i]+ar[j])%k)==0 
                && !dic.Contains($"{i},{j}"))
                {
                    dic.Add($"{i},{j}");
                    res++;
                }
            }
        }

        return res;

    }
        
    }
}