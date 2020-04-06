using System;
using System.Collections.Generic;
using Stacks_Queues.Algorithm;

namespace Stacks_Queues.HackerRank
{
    public class A_Tale_of_Two_Stacks
    {
        public void QueueProcessing(List<string> values)
        {
            var _queue = new Algorithm.Queue<int>();
            foreach (var value in values)
            {

                if (value == string.Empty)
                    throw new InvalidOperationException("Value is empty");

                var _strSplit = value.Split(' ');

                if (_strSplit[0] == "1")
                {
                    _queue.EnQueue(int.Parse(_strSplit[1]));
                }
                else if (_strSplit[0] == "2")
                {
                    try
                    {
                        _queue.DeQueue();
                    }
                    catch { }
                }
                else if (_strSplit[0] == "3")
                {
                    try
                    {
                        if (!_queue.IsNull())
                            Console.WriteLine(_queue.Peek());
                    }
                    catch { Console.WriteLine(' '); }

                }

            }
        }
    }
}