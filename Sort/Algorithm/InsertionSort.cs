using System;

namespace Sort.Algorithm
{
    public class InsertionSort
    {
        public void DoSort()
        {
            var _arr = new int[10] { 1, 4, 2, 5, 3, 7, 5, 6, 9, 0 };

            var _length = _arr.Length;
            for (int i = 0; i < _length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Less(_arr[j], _arr[j - 1]))
                        Exch(_arr, j, j - 1);
                    else break;
                }
            }
            Console.WriteLine(string.Join(",", _arr));

        }
        private bool Less(int p, int q)
        {
            return p.CompareTo(q) < 0;
        }
        private void Exch(int[] items, int p, int q)
        {
            var copy = items[p];
            items[p] = items[q];
            items[q] = copy;
        }
    }
}
