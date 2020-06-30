using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation.HackerRank
{
    public class Between_Two_Sets
    {

        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public int getTotalX(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maximumA = a.Max(); //Time-complexity O(n)
            var minimumB = b.Min(); //Time-complexity O(m)
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a) //Time complexity O(n)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b) //Time complexity O(m)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
            }
            return totalXs;
        }
    }
}