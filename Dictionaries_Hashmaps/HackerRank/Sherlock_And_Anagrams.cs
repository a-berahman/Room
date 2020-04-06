using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Hashmaps.HackerRank
{
    public class Sherlock_And_Anagrams
    {
        public int sherlockAndAnagrams(string s)
        {
            //first of all , i define variable which type is Dictionary for
            //maintain charachter frequencies
            var _dict = new Dictionary<String, int>();

            //secondly i fill my _dic variable with below way 
            for (int j = 0; j < s.Length; j++)
            {
                for (int k = 1; k <= (s.Length - j); k++)
                {
                    String sub = String.Concat(s.Substring(j, k).OrderBy(c => c));

                    if (_dict.ContainsKey(sub))
                        _dict[sub]++;
                    else
                        _dict.Add(sub, 1);
                }
            }

            //finally i return number of unordered anagrammatic pairs
            int total = 0;
            foreach (int res in _dict.Values)
                total += (res * (res - 1)) / 2;

            return total;
        }
    }
}