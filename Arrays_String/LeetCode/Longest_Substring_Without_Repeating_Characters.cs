using System;
using System.Collections.Generic;

namespace Arrays_String.LeetCode
{
    public class Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var len = s.Length; var result = 0;//longest substring
            Dictionary<char, int> map = new Dictionary<char, int>();//current index of character
            //try to extend the range [i,j]
            for (int i = 0, j = 0; j < len; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    i = Math.Max(i, map[s[j]]);
                }
                result = Math.Max(result, j - i + 1);
                map[s[j]] = j + 1;
            }
            return result;


        }
    }

}