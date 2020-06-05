using System.Collections.Generic;

namespace Dynamic_Programming.LeetCode
{
    public class Word_Break
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (wordDict == null || s == null)
            {
                return false;
            }

            var count = s.Length;
            var dp = new bool[count + 1];

            dp[0] = true;

            for (var i = 1; i < dp.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    var word = s.Substring(j, i - j);
                    if (wordDict.Contains(word) && dp[j])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[count];
        }
    }
}

// use dynamic programming would be a obvious way to do it.
// Use DP[S.length] as the sub string can be segmented into a
// space-separated sequence of one or more dictionary words.
// so we put dp[0] as empty string and it is true.
// then we do dp[1], dp[2], … dp[n]. for each of them,
// we can judge from the previous we know, such as dp[k] can be
// judge by dp[0] + string(0 – k) in dict; dp[1] + string(1 – k) in dict;
// and so on. as last, we return dp[n]





//  public IList WordBreak2(string s, ISet wordDict)
//         {
//             var res = new List();
//             var solution = string.Empty;

//             var dp = new List[s.Length + 1];
//             for (int i = 0; i < s.Length + 1; i++)
//             {
//                 dp[i] = new List();
//             }

//             for (int i = 0; i < s.Length; i++)
//             {
//                 for (int j = 0; j <= i; j++)
//                 {
//                     if (j != 0 && dp[j].Count == 0) continue;

//                     var substr = s.Substring(j, i - j + 1);
//                     if (wordDict.Contains(substr))
//                     {
//                         dp[i + 1].Add(substr);
//                     }
//                 }
//             }

//             Helper(dp, s.Length, res, solution);

//             return res;
//         }

//         private void Helper(List[] dp, int index, List res, string solution)
//         {
//             if (index == 0)
//             {
//                 solution = solution.Remove(solution.Length - 1);
//                 res.Add(solution);
//                 return;
//             }

//             foreach (var list in dp[index])
//             {
//                 solution = list + " " + solution;
//                 this.Helper(dp, index - list.Length, res, solution);
//                 solution = solution.Substring(list.Length + 1);
//             }
//         }