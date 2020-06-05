using System;
namespace Arrays_String.LeetCode
{
    // Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.
    public class One_Edit_Distance
    {
        public bool IsOneEditDistance(string s, string t)
        {
            //calculate length of both input to define which one is longer
            //if s is longer than t recall the method with different position
            // and insure that s is shorter than t
            var _sLen = s.Length;
            var _tLen = t.Length;

            if (_sLen > _tLen)
                return IsOneEditDistance(t, s);

            //the strings are not one edit away distance
            //if the length diff is more than 1 return false
            if (_tLen - _sLen > 1)
                return false;


            //define loop to traversing on two inputs
            for (int i = 0; i < _sLen; i++)
            {
                //if not is equal
                if (s[i] != t[i])
                    //if length both of them is equal substring next char should equals
                    if (_sLen == _tLen)
                        return s.Substring(i + 1).Equals(t.Substring(i + 1));
                    else
                        //else shorter with +1 longer substring    
                        return s.Substring(i).Equals(t.Substring(i + 1));


            }


            //at the end if s shorter thand t +1 and check equals and return
            return _sLen + 1 == _tLen;
        }
    }
}