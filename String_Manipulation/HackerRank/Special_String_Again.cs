using System;

namespace String_Manipulation.HackerRank
{
    public class Special_String_Again
    {
        public long substrCount(int n, string s)
        {
            long _result = 0;
            var _sameChar = new long[n];
            
            for (int t = 0; t < n; t++)
                _sameChar[t] = 0;

            int i = 0;
            while (i < n)
            {
                long _countSameContinus = 1;
                int j = i + 1;
                for (; j < n && s[i] == s[j]; j++)
                    _countSameContinus++;

                _result += (_countSameContinus * (_countSameContinus + 1) / 2);
                _sameChar[i] = _countSameContinus;
                i = j;

            }

            for (int j = 1; j < n; j++)
            {
                if (s[j] == s[j - 1])
                    _sameChar[j] = _sameChar[j - 1];
                    
                if (j > 0 && j < (n - 1) && (s[j - 1] == s[j + 1] && s[j - 1] != s[j]))
                    _result += Math.Min(_sameChar[j - 1], _sameChar[j + 1]);

            }

            return _result;

        }
    }
}