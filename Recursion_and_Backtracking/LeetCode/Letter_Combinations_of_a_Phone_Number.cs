using System.Collections.Generic;
using System.Text;

namespace Recursion_and_Backtracking.LeetCode
{
    //Back Track
    public class Letter_Combinations_of_a_Phone_Number
    {
        private Dictionary<char, List<char>> phonenumber = new Dictionary<char, List<char>>
        {
            {'0', new List<char>()},
            {'1', new List<char>()},
            {'2', new List<char>() {'a', 'b', 'c'}},
            {'3', new List<char>() {'d', 'e', 'f'}},
            {'4', new List<char>() {'g', 'h', 'i'}},
            {'5', new List<char>() {'j', 'k', 'l'}},
            {'6', new List<char>() {'m', 'n', 'o'}},
            {'7', new List<char>() {'p', 'q', 'r', 's'}},
            {'8', new List<char>() {'t', 'u', 'v'}},
            {'9', new List<char>() {'w', 'x', 'y', 'z'}}
        };
        private List<string> resstring = new List<string>();
        public IList<string> LetterCombinations(string digits)
        {
            LetterCombinationsHelper(digits, 0, new StringBuilder());

            return resstring;
        }

        private void LetterCombinationsHelper(string digits, int i, StringBuilder result)
        {
            if (i >= digits.Length)
            {
                if (result.Length > 0)
                {
                    resstring.Add(result.ToString());
                }
                return;
            }

            var cur = phonenumber[digits[i]];
            foreach (var letter in cur)
            {
                result.Append(letter);
                //Console.WriteLine(result);
                LetterCombinationsHelper(digits, i + 1, result);
                result.Remove(result.Length - 1, 1);
                //Console.WriteLine(result);
            }
        }




       
    }
}

