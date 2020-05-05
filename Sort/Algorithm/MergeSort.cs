using System;

namespace Sort.Algorithm
{
    public class MergeSort
    {
        public int[] auxirity { get; set; }
        public void DoSort(int[] arr)
        {
            auxirity = new int[arr.Length];
            Sort(arr, auxirity, 0, arr.Length - 1);
            Console.Write(string.Join(",", auxirity));
        }

        private void Sort(int[] arr, int[] auxirity, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = lo + ((hi - lo) / 2);
            Sort(arr, auxirity, lo, mid);
            Sort(arr, auxirity, mid + 1, hi);
            if (!Less(arr[mid + 1], arr[mid])) return;
            DoMerge(arr, auxirity, lo, mid, hi);
        }


        private void DoMerge(int[] arr, int[] auxirity, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                auxirity[k] = arr[k];

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) arr[k] = auxirity[j++];
                else if (j > hi) arr[k] = auxirity[i++];
                else if (Less(auxirity[j], auxirity[i])) arr[k] = auxirity[j++];
                else arr[k] = auxirity[i++];
            }
        }
        private bool Less(int p, int q)
        {
            return p.CompareTo(q) < 0;
        }
    }
}