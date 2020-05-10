using System;

namespace Heaps.Algorithm
{
    public class MaxHeap
    {
        private int[] _Arr { get; set; }
        private int N = 0;
        public MaxHeap(int capacity)
        {
            _Arr = new int[capacity + 1]; 
        }
        public bool isEmpty() { return N == 0; }


        public int DelMax()
        {
            var _max = _Arr[1];
            Exch(1, N--);
            Sink(1);
            _Arr[N + 1] = 0;
            Console.WriteLine(string.Join(", ", _Arr));
            return _max;

        }

        public void Insert(int value)
        {
            _Arr[++N] = value;
            Swim(N);
            Console.WriteLine(string.Join(", ", _Arr));
        }

        private void Swim(int n)
        {
            while (n > 1 && Less(n / 2, n))
            {
                Exch(n, n / 2);
                n = n / 2;
            }
        }
        private void Sink(int n)
        {
            while (n * 2 <= N)
            {
                var _child = n * 2;
                if (_child < N && Less(_child, _child + 1)) _child++;
                if (!Less(n, _child)) break;
                Exch(n, _child);
                n = _child;
            }
        }
        private void Exch(int p, int q)
        {
            var _copy = _Arr[p];
            _Arr[p] = _Arr[q];
            _Arr[q] = _copy;
        }

        private bool Less(int p, int q)
        {
            return _Arr[p].CompareTo(_Arr[q]) < 0;
        }
    }
}