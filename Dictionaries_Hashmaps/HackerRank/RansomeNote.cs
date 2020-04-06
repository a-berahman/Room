using System;
using System.Collections.Generic;

namespace Dictionaries_Hashmaps.HackerRank
{
    public class RansomeNote
    {
        public void checkMagazine(string[] magazine, string[] note)
        {
            var _dicMagazin = new Dictionary<string, int>();
            //firstly i prepare my _dicMagazin variable with numbe number of each word,
            //that valid in my input which is magazine string array 
            foreach (var word in magazine)
            {
                if (_dicMagazin.ContainsKey(word))
                {
                    _dicMagazin[word]++;
                }
                else
                    _dicMagazin.Add(word, 1);
            }
            //secondly i am checking notes word with count of each word in _dicmagazin variable
            foreach (var word in note)
            {
                var _countOfWord = -1;
                if (_dicMagazin.TryGetValue(word, out _countOfWord) && _countOfWord > 0)
                    _dicMagazin[word]--;
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}