using System;
using System.Collections.Generic;
namespace Arrays_String.LeetCode
{
    public class Roman_to_String
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> RomansValue = new Dictionary<string, int>();
            RomansValue.Add("I", 1);
            RomansValue.Add("V", 5);
            RomansValue.Add("X", 10);
            RomansValue.Add("L", 50);
            RomansValue.Add("C", 100);
            RomansValue.Add("D", 500);
            RomansValue.Add("M", 1000);
            RomansValue.Add("IV", 4);
            RomansValue.Add("IX", 9);
            RomansValue.Add("XL", 40);
            RomansValue.Add("XC", 90);
            RomansValue.Add("CD", 400);
            RomansValue.Add("CM", 900);

            var _total = 0;
            var _length = s.Length;

            for (int i = 0; i < _length; i++)
            {
                if (i + 1 < _length && Less(RomansValue, s[i].ToString(), s[i + 1].ToString()))
                {
                    _total += RomansValue[$"{s[i]}{s[i + 1]}"];
                    i++;
                }
                else
                    _total += RomansValue[s[i].ToString()];
            }

            return _total;
        }

        private bool Less(Dictionary<string, int> RomansValue, string p, string q)
        {
            return RomansValue[p].CompareTo(RomansValue[q]) < 0;
        }
    }
}