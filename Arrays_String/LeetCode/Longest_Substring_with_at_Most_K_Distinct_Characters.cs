using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_String.LeetCode
{
    public class Longest_Substring_with_at_Most_K_Distinct_Characters
    {


        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            s = s.Trim();
            if (k == 0 || string.IsNullOrEmpty(s)) return 0;

            var _dic = new Dictionary<char, int>();
            var _length = s.Length;
            int _max = 1;
            var left = 0; var right = 0;
            // var _hash = new char[s.Length];

            while (right < _length)
            {
                if (_dic.ContainsKey(s[right]))
                {
                    _dic[s[right]] = right;
                }
                else
                {
                    _dic.Add(s[right], right);
                    if (_dic.Count == k + 1)
                    {
                        var t = _dic.OrderBy(o => o.Value).ToList()[0];

                        _dic.Remove(t.Key);
                        left = t.Value + 1;
                    }

                }


                right++;
                _max = Math.Max(_max, right - left);
            }
            return _max;



        }
    }
}