using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_and_Backtracking.LeetCode
{
    public class Strobogrammatic_Number_II
    {
        public IList<string> FindStrobogrammatic(int n)
        {
            return Prepare(n, n);
        }
        private List<string> Prepare(int n, int len)
        {
            if (n == 0) return new List<string> { "" };
            if (n == 1) return new List<string> { "1", "0", "8" };

            var middles = Prepare(n - 2, len);
            var result = new List<string>();
            foreach (var middle in middles)
            {
                if (n < len) result.Add("0" + middle + "0");
                result.Add("1" + middle + "1");
                result.Add("6" + middle + "9");
                result.Add("8" + middle + "8");
                result.Add("9" + middle + "6");
            }
            return result;
        }
    }
}