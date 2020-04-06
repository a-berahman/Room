using System;

namespace String_Manipulation.HackerRank
{
    public class Alternating_Characters
    {
        public int alternatingCharacters(string s)
        {
            // AAAA
            // BBBBB
            // ABABABAB
            // BABABA
            // AAABBB

            var _inputLength = s.Length;
            var _input=s.ToCharArray();
            var _countDelete = 0;
            var _previus = ' ';
            foreach (var item in _input)
            {

                if (_previus == item)
                    _countDelete++;

                _previus = item;

            }
            return _countDelete;
        }
    }
}