using System.Collections.Generic;
using System;
namespace Arrays_String.CrackingTheCodingInterview
{
    public class Palindrome_Permutation
    {
        public bool IsPermutationOfPalindrome(string str)
        {
            var outPut = new List<string>();
            str=str.ToUpper();
            GetPermutation(str.ToCharArray(), 0, ref outPut);
            return HasPalindrome(outPut);
        }
        private void GetPermutation(char[] str, int first, ref List<string> outPut)
        {
            if (str.Length == first)
                outPut.Add(new string(str));

            for (int i = first; i < str.Length; i++)
            {
                Swap(str, i, first);
                GetPermutation(str, first + 1, ref outPut);
                Swap(str, i, first);
            }
        }
        private bool HasPalindrome(List<string> lists)
        {
            foreach (var item in lists)
            {
                var temp = item.Trim();
                temp = temp.Replace(" ", "");
                var right = temp.Length - 1;
                var left = 0;
                var flag = true;
                while (left < right)
                {
                    if (temp[left] != temp[right])
                    {
                        flag = false;
                        break;
                    }
                    left++;
                    right--;
                }
                if (flag)
                    return true;
            }

            return false;
        }
        private void Swap(char[] str, int p, int q)
        {
            var temp = str[p];
            str[p] = str[q];
            str[q] = temp;
        }

    }
}