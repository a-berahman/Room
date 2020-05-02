using System;

namespace Sort.Algorithm
{
    public class ShellSort
    {
        public void DoSort()
        {
            var _arr = new int[10] { 0, 2, 4, 1, 6, 7, 1, 9, 10, 23 };
            var _length = _arr.Length;

            var h = 1;
            //3x+1 increment sequence
            while (h < _length / 3) h = 3 * h + 1;

            while (h >= 1)
            {
                //insertion sort : https://links.berahman.me/insertionsort
                for (int i = h; i < _length; i++)
                    for (int j = i; j >= h && Less(_arr[j], _arr[j - h]); j -= h)
                        Exch(_arr, j, j - h);

                //move to next incremention
                h = h / 3;
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