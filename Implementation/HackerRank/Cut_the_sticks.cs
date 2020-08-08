using System;
using System.Collections.Generic;

namespace Implementation.HackerRank
{
    public class Cut_the_sticks
    {
        public int[] cutTheSticks(int[] arr)
        {
            Array.Sort(arr);
            var len=arr.Length;
            if(len<=1) return new int[1]{1};
            if(arr[0]==arr[len-1]) return   new int[1]{arr.Length};
            

            var res=new List<int>();
            res.Add(len);
            for(int i=0; i<len;i++){
                var count=0;
                if(arr[i]==0) continue;
                var min=arr[i];
                for(int j=0; j<len ;j++)
                {
                    if(arr[j]==0) continue;
                    arr[j]=arr[j]-min;
                    if(arr[j]!=0) count++;
                }
                if(count!=0) res.Add(count);
            }
            return res.ToArray();
        }
    }
}