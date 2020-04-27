using System.Collections.Generic;
using Stacks_Queues.Algorithm;

namespace Stacks_Queues.HackerRank
{
    public class Balanced_Brackets
    {
        public string isBalanced(string s)
        {
            if (s.Length < 2)
                return "NO";

            var _currentValues = s.ToCharArray();
            var _stack = new Algorithm.StackWithLinkedList<char>();
            for (int i = 0; i < _currentValues.Length; i++)
            {
                if (_currentValues[i].isOpenBracket())
                {
                    _stack.Push(_currentValues[i]);
                }
                else
                {
                    if (_stack.IsNull())
                        return "NO";

                    switch (_currentValues[i])
                    {
                        case '}':
                            if (_stack.Peek() == '{')
                            {
                                _stack.Pop();
                            }
                            else { return "NO"; }
                            break;
                        case ')':
                            if (_stack.Peek() == '(')
                            {
                                _stack.Pop();
                            }
                            else { return "NO"; }
                            break;
                        case ']':
                            if (_stack.Peek() == '[')
                            {
                                _stack.Pop();
                            }
                            else { return "NO"; }
                            break;
                    }

                }
            }
            if (!_stack.IsNull())
                return "NO";


            return "YES";

        }

    }
    static class Extention
    {
        public static bool isOpenBracket(this char value)
        {
            var _values = new List<char> { '{', '[', '(' };
            return _values.Contains(value);
        }
    }
}