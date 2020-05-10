using System;

namespace Sort.Algorithm
{
    public class QuickSort
    {
        public void DoSort(int[] items)
        {
            Sort(items, 0, items.Length - 1);
            Console.Write(string.Join(", ", items));
        }
        public void Sort(int[] items, int lowIndex, int highIndex)
        {
            if (highIndex <= lowIndex) return;
            //find partition key
            var _index = Partitioning(items, lowIndex, highIndex);
            //sort each piece recursively
            Sort(items, lowIndex, _index - 1);
            Sort(items, _index + 1, highIndex);
        }
        public void SortWithDuplicateKeys(int[] items, int lowIndex, int highIndex)
        {
            if (highIndex <= lowIndex) return;
            //entries between _lt and _gt  equal to partition item _value
            var _lt = lowIndex; var _gt = highIndex;
            //let _value be partitioning item items[lowIndex]
            var _value = items[lowIndex];
            int _i = lowIndex;
            //from left to right
            while (_i <= _gt)
            {
                var _cmp = items[_i].CompareTo(_value);
                if (_cmp < 0) EXCH(items, _i++, _lt++);
                else if (_cmp > 0) EXCH(items, _i, _gt--);
                else _i++;
            }
            //sort each piece recursively 
            Sort(items, lowIndex, _lt - 1);
            Sort(items, _gt + 1, highIndex);

        }

        private int Partitioning(int[] items, int lowIndex, int highIndex)
        {

            int i = lowIndex; int j = highIndex + 1;

            while (true)
            {
                //find item on left to swap
                while (Less(items[++i], items[lowIndex]))
                    if (i == highIndex) break;
                //find item on right swap
                while (Less(items[lowIndex], items[--j]))
                    if (j == lowIndex) break;
                //if pointers cross
                if (i >= j) break;
                //swap
                EXCH(items, i, j);
            }
            //swap with partition item
            EXCH(items, lowIndex, j);

            return j;
        }

        private void EXCH(int[] items, int p, int q)
        {
            var _copy = items[p];
            items[p] = items[q];
            items[q] = _copy;
        }

        private bool Less(int v1, int v2)
        {
            return v1.CompareTo(v2) < 0;
        }

    }
}