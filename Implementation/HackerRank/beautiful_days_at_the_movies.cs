using System;
using System.Linq;

namespace Implementation.HackerRank
{
    public class beautiful_days_at_the_movies
    {
        public int beautifulDays(int i, int j, int k)
        {

            var len = j - i;
            int count = 0;
            while(i<=j)
            {
                if (Math.Abs(i - Reverse(i)) % k == 0) count++;
                i++;
            }

            return count;
        }

        private int Reverse(int num)
        {
            
            var arr=num.ToString().ToArray();
            var len=arr.Length-1;
            var mid=len/2;
            for(int i=0;i<=mid;i++)
            {
                var temp=arr[i];
                arr[i]=arr[(arr.Length-1)-i];
                arr[len-i]=temp;
            }
            return int.Parse(new string(arr));
        }
    }
}