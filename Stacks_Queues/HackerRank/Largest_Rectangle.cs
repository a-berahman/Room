using System;
using Stacks_Queues.Algorithm;

namespace Stacks_Queues.HackerRank
{
    public class Largest_Rectangle
    {
        public long largestRectangle(int[] h)
        {
            // first of all i define variable which type is stack.
            var _stack = new StackWithLinkedList<int>();

            var _maximum_area = 0; //as a result that should return at the end of method
            var _lengthOfArray = h.Length;
            var _counter = 0;

            // secondly start from first bar, and do following for every bar ‘h[i]’ where ‘_counter’ varies from 0 to _lengthOfArray-1.
            while (_counter < _lengthOfArray)
            {
                if (_stack.IsNull() || h[_stack.Peek()] <= h[_counter])
                {
                    _stack.Push(_counter++);
                }
                else if (h[_stack.Peek()] > h[_counter])
                {
                    //keep top of stack and remove it
                    var _topOfStack = _stack.Pop();
                    //calculate with top of stack
                    var _calculateArea = h[_topOfStack] * (_stack.IsNull() ? _counter : _counter - _stack.Peek() - 1);
                    if (_maximum_area < _calculateArea)
                        _maximum_area = _calculateArea;

                }
            }

            //finally if stack not is null should remove one by one from stack and calculate area with each one
            while (!_stack.IsNull())
            {
                //keep top of stack and remove it
                var _topOfStack = _stack.Pop();
                //calculate with top of stack
                var _calculateArea = h[_topOfStack] * (_stack.IsNull() ? _counter : _counter - _stack.Peek() - 1);
                if (_maximum_area < _calculateArea)
                    _maximum_area = _calculateArea;
            }

            return _maximum_area;


        }

    }
}