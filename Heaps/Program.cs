using System;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var _maxHeap = new Heaps.Algorithm.MaxHeap(10);
            _maxHeap.Insert(2);
            _maxHeap.Insert(1);
            _maxHeap.Insert(4);
            _maxHeap.Insert(9);
            _maxHeap.Insert(6);
            var _removeItem = _maxHeap.DelMax();
            Console.WriteLine(_removeItem);

            


        }

     
    }
}
