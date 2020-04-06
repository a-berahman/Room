using System;
using System.Collections.Generic;

namespace Dictionaries_Hashmaps.HackerRank
{
    public class Frequency_Queries
    {
        public List<int> freqQuery(List<List<int>> queries)
        {
            //firstly, i define 2 variable, one of them for maintain frequency of each element
            //and another one for maintain frequency count
            //for ex: i have {2,3,3} -> i have 1 of Two and 2 of 3, so my count of Frequency is {2=1, 3=2}
            //and my frequency count is {1=1, 2=1} 
            var _countOfFreq = new Dictionary<int, long>();
            var _freqCount = new Dictionary<long, int>();

            var _freqQuery = new List<int>();

            //i looping through complete list
            foreach (var item in queries)
            {
                //and check first element of each list to provide the related operation
                switch (item[0])
                {
                    case 1:
                        if (_countOfFreq.ContainsKey(item[1]))
                            Decrease(_freqCount, _countOfFreq[item[1]]);

                        Increse(_countOfFreq, item[1]);
                        Increse(_freqCount, _countOfFreq[item[1]]);

                        break;
                    case 2:
                        if (_countOfFreq.ContainsKey(item[1]))
                        {
                            var _currentCount = _countOfFreq[item[1]];
                            if (_currentCount > 0)
                            {
                                Decrease(_freqCount, _currentCount);
                                Decrease(_countOfFreq, item[1]);
                                Increse(_freqCount, _countOfFreq[item[1]]);
                            }
                        }
                        break;
                    case 3:

                        if (_freqCount.ContainsKey(item[1]) && _freqCount[item[1]]>0)
                            _freqQuery.Add(1);
                        else
                            _freqQuery.Add(0);
                        break;
                }

            }

            return _freqQuery;

        }

        private void Decrease(Dictionary<int, long> countOfFreq, int key)
        {
            long _result = 0;
            if (countOfFreq.TryGetValue(key, out _result) && _result > 0)
                countOfFreq[key]--;
        }
        private void Decrease(Dictionary<long, int> freqCount, long key)
        {
            int _result = 0;
            if (freqCount.TryGetValue(key, out _result) && _result > 0)
                freqCount[key]--;
        }

        private void Increse(Dictionary<int, long> countOfFreq, int value)
        {
            if (countOfFreq.ContainsKey(value))
                countOfFreq[value]++;
            else
                countOfFreq.Add(value, 1);
        }
        private void Increse(Dictionary<long, int> freqCount, long value)
        {
            if (freqCount.ContainsKey(value))
                freqCount[value]++;
            else
                freqCount.Add(value, 1);
        }
    }
}