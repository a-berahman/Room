using System.Collections.Generic;
using System;
using System.Linq;

namespace Recursion_and_Backtracking.LeetCode
{
    public class Regular_Expression_Matching
    {
        public bool IsMatch(string text, string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return string.IsNullOrEmpty(text);

            bool first_match = (!string.IsNullOrEmpty(text) &&
                                   (pattern[0] == text[0] || pattern[0] == '.'));

            if (pattern.Length >= 2 && pattern[1] == '*')
            {
                return (IsMatch(text, pattern.Substring(2)) ||
                        (first_match && IsMatch(text.Substring(1), pattern)));
            }
            else
            {
                return first_match && IsMatch(text.Substring(1), pattern.Substring(1));
            }
        }
    }
}