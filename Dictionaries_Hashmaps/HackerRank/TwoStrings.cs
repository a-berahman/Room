using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Hashmaps.HackerRank
{
    public class TwoStrings
    {
        public string twoStrings(string s1, string s2)
        {
            var _firstHash = new HashSet<char>(s1.ToList());
            var _secondHash = new HashSet<char>(s2.ToList());
            _firstHash.IntersectWith(_secondHash);
            if (_firstHash.Any())
                return "YES";
            return "NO";

        }
    }
}