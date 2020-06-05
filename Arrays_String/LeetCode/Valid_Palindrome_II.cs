using System;
namespace Arrays_String.LeetCode
{
    public class Valid_Palindrome_II
    {
        public bool isPalindromeRange(string s, int i, int j)
        {
            for (int k = i; k <= i + (j - i) / 2; k++)
            {
                if (s[k] != s[j - k + i]) return false;
            }
            return true;
        }
        // Suppose we want to know whether s[i], s[i+1], ..., s[j]
        // form a palindrome. If i >= j then we are done.
        // If s[i] == s[j] then we may take i++; j--. Otherwise,
        // the palindrome must be either s[i+1], s[i+2], ...,
        // s[j] or s[i], s[i+1], ..., s[j-1], and we should check both cases.
        public bool ValidPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    int j = s.Length - 1 - i;
                    return (isPalindromeRange(s, i + 1, j) ||
                            isPalindromeRange(s, i, j - 1));
                }
            }
            return true;
        }
    }
}