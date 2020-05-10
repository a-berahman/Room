using System;

namespace Sort.Algorithm
{
    public class HeapSort
    {
        public void DoSort()
        {
            var _items = new char[] { 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
            var _length = _items.Length - 1;

            for (int i = (_length / 2) - 1; i >= 0; i--)
            {
                Sink(_items, i, _length);
            }
            Console.WriteLine(string.Join(", ", _items));
            while (_length > 0)
            {
                Swap(_items, 0, _length);
                Sink(_items, 0, --_length);
            }
            Console.WriteLine(string.Join(", ", _items));
        }
        private static void Sink(char[] items, int i, int length)
        {
            while ((i * 2) + 1 <= length)
            {
                int _child = (i * 2) + 1;
                if (_child < length && Less(items, _child, _child + 1)) _child++;
                if (!Less(items, i, _child)) break;
                Swap(items, i, _child);
                i = _child;
            }
        }

        private static void Swap(char[] items, int p, int q)
        {
            var _copy = items[p];
            items[p] = items[q];
            items[q] = _copy;
        }

        private static bool Less(char[] items, int p, int q)
        {
            return items[p].CompareTo(items[q]) < 0;
        }
    }
}