using System;

namespace Implementation.HackerRank
{
    public class Append_and_Delete
    {
        public string appendAndDelete(string s, string t, int k)
        {
            if((s.Length+t.Length)<=k) return "Yes";
            if (Math.Abs(s.Length - t.Length) > k)   return "No";

            var tlen=t.Length;
            var slen=s.Length;
            int counter=0;

            while(counter<slen && counter<tlen && s[counter]==t[counter]) counter++;
            int req=tlen-counter+slen-counter;
            k-=req;
            return k>=0 && k%2==0?"Yes":"No";


            // var desired = new int[26];
            // foreach (var ch in t)
            // {
            //     desired[ch - 'a']++;
            // }
            // foreach (var ch in s)
            // {
            //     if (desired[ch - 'a'] <= 0)
            //         k--;
            //     else desired[ch - 'a']--;

            //     if (k < 0)
            //         return "No";
            // }

            // return k < 0 ?  "No": "Yes";
        }
    }
}