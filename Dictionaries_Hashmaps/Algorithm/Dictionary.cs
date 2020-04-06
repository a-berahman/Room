using System;
using System.Collections.Generic;

namespace Dictionaries_Hashmaps.Algorithm
{
    public class Dictionary
    {
        public void Demo()
        {
            var _dic = new Dictionary<string, int>();
            _dic.Add("A", 1);
            _dic.Add("B", 2);
            Console.WriteLine(_dic["A"]);
            Console.WriteLine(_dic["B"]);
            try
            {
                Console.WriteLine(_dic["C"]);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            var _outPut = -1;
            if (_dic.TryGetValue("C",out _outPut))
                Console.WriteLine($"C  value is {_outPut}");
            else
                Console.WriteLine("C not is Exist");

            foreach (var key in _dic.Keys)
                Console.WriteLine(key);
            foreach (var value in _dic.Values)
                Console.WriteLine(value);

        }
    }
}