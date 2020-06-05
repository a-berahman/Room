using System;
namespace Dynamic_Programming.LeetCode
{
    public class Decode_Ways
    {
        public int NumDecodings(string s)
        {
            if (s[0] == '0') return 0;
            return countDecoding(s.ToCharArray(), s.Length);
        }
        private int countDecoding(char[] digits, int n)
        {

            // base cases 

            if (n == 0 || n == 1)
                return 1;

            // Initialize count 
            int count = 0;

            // If the last digit is not 0, then  
            // last digit must add to 
            // the number of words 
            if (digits[n - 1] > '0')
                count = countDecoding(digits, n - 1);

            // If the last two digits form a number 
            // smaller than or equal to 26, then  
            // consider last two digits and recur 
            if (digits[n - 2] == '1' ||
                        (digits[n - 2] == '2' &&
                           digits[n - 1] < '7'))
                count += countDecoding(digits, n - 2);

            return count;
        }

    }
}

//this problem is recursive and we can broke to subproblems
//we start from end of the given digits sequence
//and initilize the total of the decoding as zero
//and we recure for two subproblems:
//first : if the last digit s non-zero for recuring (n-1) and add the result to total count
//second: if the last 2 digit , recure for remaining n-2 digits.



//  public class Solution
//     {
//         private const int MODULO = 1_000_000_007;

//         private void Helper(int[] dp, ref string s, int i, int currDigit)
//         {
//             //single digit
//             dp[i] += (i == s.Length - 1 ? 1 : dp[i + 1]);
//             dp[i] = dp[i] % MODULO;

//             if (i != s.Length - 1)
//             {
//                 //two digits
//                 if (s[i + 1] != '*')
//                 {
//                     int candidate = currDigit * 10 + s[i + 1] - '0';
//                     if (candidate >= 1 && candidate <= 26)
//                     {
//                         dp[i] += (i != s.Length - 2 ? dp[i + 2] : 1);
//                         dp[i] = dp[i] % MODULO;
//                     }
//                 }
//                 else
//                 {
//                     for (int k = 1; k <= 9; k++)
//                     {
//                         int candidate = currDigit * 10 + k;
//                         if (candidate >= 1 && candidate <= 26)
//                         {
//                             dp[i] += (i != s.Length - 2 ? dp[i + 2] : 1);
//                             dp[i] = dp[i] % MODULO;
//                         }
//                     }
//                 }
//             }
//         }

//         public int NumDecodings(string s)
//         {
//             checked
//             {
//                 int[] dp = new int[s.Length];

//                 for (int i = s.Length - 1; i >= 0; i--)
//                 {
//                     if (s[i] == '0')
//                     {
//                         dp[i] = 0;
//                         continue;
//                     }

//                     if (s[i] == '*')
//                     {
//                         for (int j = 1; j <= 9; j++)
//                         {
//                             Helper(dp, ref s, i, j);
//                         }

//                         continue;
//                     }

//                     Helper(dp, ref s, i, (s[i] - '0'));
//                 }

//                 return dp[0];
//             }
//         }
//     }