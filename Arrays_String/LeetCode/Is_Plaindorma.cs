using System;
namespace Arrays_String.LeetCode
{
    public class Is_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToUpper();
            s = s.Replace(" ", "");

            int i = 0; int j = s.Length - 1;
            while (i < j)
            {

                if (!Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                else if (!Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }
                else if (s[i] != s[j])
                    return false;
                j--;
                i++;
            }
            return true;
        }
    }
}