using System.Collections.Generic;
using System;
using System.Linq;

namespace Recursion_and_Backtracking.LeetCode
{
    //Back Track
    public class Remove_Invalid_Parentheses
    {
        // method checks if character is  
        // parenthesis(open or closed) 
        private bool isParenthesis(char c)
        {
            return ((c == '(') || (c == ')'));
        }

        // method returns true if string contains  
        // valid parenthesis 
        private bool isValidString(String str)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    cnt++;
                else if (str[i] == ')')
                    cnt--;
                if (cnt < 0)
                    return false;
            }
            return (cnt == 0);
        }

        // method to remove invalid parenthesis 
        public IList<string> RemoveInvalidParentheses(string s)
        {
            if (s == null || s == "")
                return new List<string> { "" };

            // visit set to ignore already visited string 
            HashSet<String> visit = new HashSet<String>();

            // queue to maintain BFS 
            Queue<String> q = new Queue<String>();
            String temp;
            bool level = false;

            // pushing given string as  
            // starting node into queue 
            q.Enqueue(s);
            visit.Add(s);
            List<string> result = new List<string>();
            while (q.Count != 0)
            {
                s = q.Peek(); q.Dequeue();
                if (isValidString(s))
                {
                    Console.WriteLine(s);
                    result.Add(s);
                    // If answer is found, make level true 
                    // so that valid string of only that level 
                    // are processed. 
                    level = true;
                }

                if (level)
                    continue;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!isParenthesis(s[i]))
                        continue;

                    // Removing parenthesis from str and 
                    // pushing into queue,if not visited already 
                    temp = s.Substring(0, i) +
                           s.Substring(i + 1);
                    if (!visit.Contains(temp))
                    {
                        q.Enqueue(temp);
                        visit.Add(temp);
                    }
                }
            }
            return result;
        }

    }
}







// class Solution {

//   private Set<String> validExpressions = new HashSet<String>();

//   private void recurse(
//       String s,
//       int index,
//       int leftCount,
//       int rightCount,
//       int leftRem,
//       int rightRem,
//       StringBuilder expression) {

//     // If we reached the end of the string, just check if the resulting expression is
//     // valid or not and also if we have removed the total number of left and right
//     // parentheses that we should have removed.
//     if (index == s.length()) {
//       if (leftRem == 0 && rightRem == 0) {
//         this.validExpressions.add(expression.toString());
//       }

//     } else {
//       char character = s.charAt(index);
//       int length = expression.length();

//       // The discard case. Note that here we have our pruning condition.
//       // We don't recurse if the remaining count for that parenthesis is == 0.
//       if ((character == '(' && leftRem > 0) || (character == ')' && rightRem > 0)) {
//         this.recurse(
//             s,
//             index + 1,
//             leftCount,
//             rightCount,
//             leftRem - (character == '(' ? 1 : 0),
//             rightRem - (character == ')' ? 1 : 0),
//             expression);
//       }

//       expression.append(character);

//       // Simply recurse one step further if the current character is not a parenthesis.
//       if (character != '(' && character != ')') {

//         this.recurse(s, index + 1, leftCount, rightCount, leftRem, rightRem, expression);

//       } else if (character == '(') {

//         // Consider an opening bracket.
//         this.recurse(s, index + 1, leftCount + 1, rightCount, leftRem, rightRem, expression);

//       } else if (rightCount < leftCount) {

//         // Consider a closing bracket.
//         this.recurse(s, index + 1, leftCount, rightCount + 1, leftRem, rightRem, expression);
//       }

//       // Delete for backtracking.
//       expression.deleteCharAt(length);
//     }
//   }

//   public List<String> removeInvalidParentheses(String s) {

//     int left = 0, right = 0;

//     // First, we find out the number of misplaced left and right parentheses.
//     for (int i = 0; i < s.length(); i++) {

//       // Simply record the left one.
//       if (s.charAt(i) == '(') {
//         left++;
//       } else if (s.charAt(i) == ')') {
//         // If we don't have a matching left, then this is a misplaced right, record it.
//         right = left == 0 ? right + 1 : right;

//         // Decrement count of left parentheses because we have found a right
//         // which CAN be a matching one for a left.
//         left = left > 0 ? left - 1 : left;
//       }
//     }

//     this.recurse(s, 0, 0, 0, left, right, new StringBuilder());
//     return new ArrayList<String>(this.validExpressions);
//   }
// }