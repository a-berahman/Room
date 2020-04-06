using System;
using System.Collections.Generic;

namespace String_Manipulation.HackerRank
{
    public class Making_Anagrams
    {
        public int makeAnagram(string a, string b)
        {
            var _minDeletation = 0;

            var _firstInput = a.ToCharArray();
            var _secondInput = b.ToCharArray();

            var _firstDic = new Dictionary<char, int>();
            var _secondDic = new Dictionary<char, int>();


            foreach (var item in _firstInput)
            {
                if (_firstDic.ContainsKey(item))
                    _firstDic[item]++;
                else _firstDic.Add(item, 1);
            }

            foreach (var item in _secondInput)
            {
                if (_secondDic.ContainsKey(item))
                    _secondDic[item]++;
                else _secondDic.Add(item, 1);
            }

            foreach (var item in _firstDic)
            {
                if (_secondDic.ContainsKey(item.Key))
                {
                    if (_secondDic[item.Key] >= item.Value)
                        _minDeletation += _secondDic[item.Key] - item.Value;
                    else
                        _minDeletation += item.Value - _secondDic[item.Key];

                    // _secondDic[item.Key] = 0;
                    _secondDic.Remove(item.Key);

                }
                else
                {
                    _minDeletation += item.Value;
                }
                // _firstDic[item.Key] = 0;
            }


            foreach (var item in _secondDic)
            {
                if (item.Value > 0)
                {
                    _minDeletation += item.Value;
                    // _secondDic[item.Key] = 0;
                }
            }
            return _minDeletation;


        }
    }
}