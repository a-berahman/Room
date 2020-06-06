using System.Collections.Generic;
using System.Linq;

namespace String_Manipulation.HackerRank
{
    public class Super_Reduced_String
    {
        public string superReducedString(string s)
        {
            //check specific condition
            if (string.IsNullOrEmpty(s))
                return "Empty String";
            if (s.Length <= 1)
                return s;

            //first Approach
            // var stack = new Stack<char>();
            // for (int j = 0; j < s.Length; j++)
            // {
            //     if (s[j] == stack.Peek())
            //     {
            //         stack.Pop();
            //     }
            //     else stack.Push(s[j]);
            // }

            // var sb = new System.Text.StringBuilder();
            // while (stack.Any())
            // {
            //     sb.Append(stack.Pop());
            // }
            // s = sb.ToString();

            //Second Approach
            // traversing on input
            for (int i = 1; i < s.Length; i++)
            {
                //if current char is equal with previous char
                //remove both
                if (s[i] == s[i - 1])
                {
                    s = s.Remove(i, 1);
                    s = s.Remove(i - 1, 1);
                    i = 0;
                }
            }



            if (string.IsNullOrEmpty(s))
                return "Empty String";
            return s;
        }
    }
}