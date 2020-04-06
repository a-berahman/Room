using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionaries_Hashmaps
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple samples of dictionaries Type
            new Algorithm.Dictionary().Demo();

            //simple samples of hashSet Type
            new Algorithm.HashSet().Demo();


            //Problem statment is 'Hash Tables: Ransom Note' -> //https://bit.ly/2QEtgxo
            var _magazine = new string[] { "two", "times", "three", "is", "not", "four" };
            var _note = new string[] { "two", "times", "two", "is", "four" };
            new HackerRank.RansomeNote().checkMagazine(_magazine, _note);

            //Problem statment is 'Two Strings' -> https://bit.ly/3aaqWGd
            new HackerRank.TwoStrings().twoStrings("hello", "world");

            //Problem statment is 'Sherlock and Anagrams' -> https://bit.ly/33G1LsJ
            Console.WriteLine(new HackerRank.Sherlock_And_Anagrams().sherlockAndAnagrams("ifailuhkqq"));

            //Problem statment is 'Count Triplets' -> https://bit.ly/2JemHxG
            Console.WriteLine(new HackerRank.Count_Triplets().countTriplets(new List<long> { 1, 2, 2, 4 }, 2));


            //Problem statment is 'Frequency Queries' -> https://bit.ly/2Ut5IfW
            var _list = new List<List<int>>();
            _list.Add(new List<int> { 1, 3 });
            _list.Add(new List<int> { 2, 3 });
            _list.Add(new List<int> { 3, 2 });
            _list.Add(new List<int> { 1, 4 });
            _list.Add(new List<int> { 1, 5 });
            _list.Add(new List<int> { 1, 5 });
            _list.Add(new List<int> { 1, 4 });
            _list.Add(new List<int> { 3, 2 });
            _list.Add(new List<int> { 2, 4 });
            _list.Add(new List<int> { 3, 2 });

            Console.WriteLine(string.Join(',',new HackerRank.Frequency_Queries().freqQuery(_list)));





        }
    }
}
