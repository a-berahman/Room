using System;
using System.Collections.Generic;

namespace Arrays_String.LeetCode
{
    public class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var _groups = new List<IList<string>>();
            var _dic = new Dictionary<string, int>();
            int j = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                var _currentArr = strs[i].ToCharArray();
                Array.Sort(_currentArr);
                var _currentSorted = string.Join("", _currentArr);
                if (_dic.ContainsKey(_currentSorted))
                {
                    _groups[_dic[_currentSorted]].Add(strs[i]);
                }
                else
                {
                    _dic.Add(_currentSorted, j); _groups.Add(new List<string> { strs[i] });
                    j++;
                }
            }
            return _groups;
        }
    }
}