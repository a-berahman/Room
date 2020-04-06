using System;
using System.Text;

namespace String_Manipulation.HackerRank
{
    public class Common_Child
    {
        public int commonChild(string s1, string s2)
        {
            //firstly, we need to know what is strings length
            //so i define 2 variable which name is below line and store strings length
            int _lengthFirst = s1.Length;
            int _lengthSecond = s2.Length;
            //secondly i define one variable which type is array int
            //this variable capacity is equals with string length + 1
            int[] _memo = new int[_lengthSecond + 1];
            //looging through first string length 
            for (int i = 1; i <= _lengthFirst; i++)
            {
                //maintain _memo value as a previus value
                int _previous = 0;
                for (int j = 1; j <= _lengthSecond; j++)
                {
                    //keep memo current value in _temp variable because i need
                    //pass the value in a _previous variable after assign new value
                    int _temp = _memo[j];

                    if (s1[i - 1] == s2[j - 1])
                        _memo[j] = _previous + 1;
                    else _memo[j] = Math.Max(_memo[j], _memo[j - 1]);
                    //so i fill up _previus variable with _memo variable but previus
                    //_memo variable that before assigning a new variable in top operation
                    //that i keep in _temp variable
                    _previous = _temp;
                } 
            }
            //and finally return the result
            return _memo[_lengthSecond];
        }
    }
}