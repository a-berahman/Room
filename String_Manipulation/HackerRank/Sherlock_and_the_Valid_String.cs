using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Manipulation.HackerRank
{
    public class Sherlock_and_the_Valid_String
    {
        public string isValid(string s)
        {
            //first of all, i check 2 condition that if they implement 
            //we should return the result without long operation
            if (String.IsNullOrEmpty(s)) return "NO";
            if (s.Length == 1) return "YES";

            //after that, i convert input to array and define 2 variable
            //for maintaining frequency of charachter and count of each frequency
            var _arr = s.ToCharArray();
            var _frequencyDic = new Dictionary<char, long>();
            var _frequencyCountDic = new Dictionary<long, long>();

            //fill up frequency with looping through complete array
            foreach (var item in _arr)
            {
                if (_frequencyDic.ContainsKey(item)) _frequencyDic[item]++;
                else _frequencyDic.Add(item, 1);
            }
            //fill up count of frequecy with looping through _frequencyDic variable
            foreach (var item in _frequencyDic)
            {
                if (_frequencyCountDic.ContainsKey(item.Value))
                    _frequencyCountDic[item.Value]++;
                else _frequencyCountDic.Add(item.Value, 1);
            }


            //final check all question statement condition
            if (_frequencyCountDic.Count == 1) return "YES";
            else if (_frequencyCountDic.Count == 2)
            {
                var _minus = _frequencyCountDic.Keys.First() - _frequencyCountDic.Keys.Last();

                if (_minus < 0)
                    _minus = _minus * -1;

                var _valid = false;
                foreach (var item in _frequencyCountDic)
                {
                    if (item.Value == 1 && (_minus == 1 || item.Key == 1))
                        _valid = true;
                }
                if (_valid)
                    return "YES";
            }

            return "NO";
        }

    }
}