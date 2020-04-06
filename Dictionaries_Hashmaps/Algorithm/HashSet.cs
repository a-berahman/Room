using System;
using System.Collections.Generic;

namespace Dictionaries_Hashmaps.Algorithm
{
    public class HashSet
    {
        public void Demo()
        {
            var _firstSet = new HashSet<int>() { 1, 2, 3, 4, 5 };
            var _secondSet = new HashSet<int>() { 1, 2, 3, 4, 5 };
            var _thirdSet = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine($"do you have 4 in _firstSet variable? {_firstSet.Contains(4)}");
            Console.WriteLine($"do you have 6 in _secondSet variable? {_secondSet.Contains(6)}");
            Console.WriteLine($"_firstSet equals _secondSet? {_firstSet.SetEquals(_secondSet)}");
            var _firstHash = _firstSet.GetHashCode();
            var _secondHash = _secondSet.GetHashCode();
            Console.WriteLine($"_firstHash equals _secondHash? {_firstHash == _secondHash}");

            Console.WriteLine($"is _thirdSet variable a proper superset of _firstSet? {_thirdSet.IsProperSupersetOf(_firstSet)}");
            _thirdSet.IntersectWith(_firstSet);
            Console.WriteLine("intersection of _thirdSet  with _firstSet is :");
            foreach (var item in _thirdSet)
            {
                Console.WriteLine(item);
            }

            _thirdSet = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            _thirdSet.ExceptWith(_firstSet);
            Console.WriteLine("_thirdSet except of _firstSet  is :");
            foreach (var item in _thirdSet)
            {
                Console.WriteLine(item);
            }







        }
    }
}