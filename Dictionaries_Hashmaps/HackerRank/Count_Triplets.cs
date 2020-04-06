using System;
using System.Collections.Generic;

namespace Dictionaries_Hashmaps.HackerRank
{
    public class Count_Triplets
    {
        public long countTriplets(List<long> arr, long r)
        {
            long _countOfTriplets = 0;
            //according to problem statment we should find count of tripets in arr
            //and such that elements at those indices are in https://bit.ly/2vMtv2e
            //so i follow right formula : (arr element/r , arr element , arr element*r)
            //and according to (arr element/r , arr element , arr element*r)
            //i should create 2 variable for maintain left and right side value, which name is :
            var _rightDic = new Dictionary<long, int>();
            var _leftDic = new Dictionary<long, int>();

            //firstly i want to maintain count of each array element in _rightDic variable
            foreach (var item in arr)
            {
                if (_rightDic.ContainsKey(item))
                    _rightDic[item]++;
                else _rightDic.Add(item, 1);
            }

            for (int i = 0; i < arr.Count; i++)
            {
                //(arr element/r , _mid = arr element , arr element*r)
                var _mid = arr[i];

                //and we need to take count of frequency from _leftDic and _rightDic variable
                //so i define 2 variable below
                long _rightFreq = 0;
                long _leftFreq = 0;

                //we reduce _rightDic value because of we should add to left
                _rightDic[_mid]--;

                if (_leftDic.ContainsKey(_mid / r) && _mid % r == 0)
                    _leftFreq = _leftDic[_mid / r];

                if (_rightDic.ContainsKey(_mid * r))
                    _rightFreq = _rightDic[_mid * r];

                _countOfTriplets += _leftFreq * _rightFreq;

                if (_leftDic.ContainsKey(_mid))
                    _leftDic[_mid]++;
                else
                    _leftDic.Add(_mid, 1);

            }

            return _countOfTriplets;

        }

    }
}