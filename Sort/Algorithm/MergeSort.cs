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
            Console.Write(string.Join(",", arr));
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

    public class MergeSortBU
    {
        public void DoSort(int[] arr)
        {
            var _length = arr.Length;
            var _auxiliary = new int[_length];
            for (int siz = 1; siz < _length; siz += siz)
                for (int j = 0; j < _length - siz; j += siz + siz)
                    DoMerge(arr, _auxiliary, j, j + siz - 1, Math.Min(j + siz + siz - 1, _length - 1));

            Console.Write(string.Join(", ", arr));
        }

        private void DoMerge(int[] arr, int[] auxiliary, int low, int mid, int high)
        {
            int i = low; int j = mid + 1;
            for (int k = 0; k < arr.Length; k++)
                auxiliary[k] = arr[k];

            for (int k = low; k < high; k++)
            {
                if (i > mid) arr[k] = auxiliary[j++];
                else if (j > high) arr[k] = auxiliary[i++];
                else if (Less(auxiliary[j], auxiliary[i])) arr[k] = auxiliary[j++];
                else arr[k] = auxiliary[i++];
            }
        }

        private bool Less(int v1, int v2)
        {
            return v1.CompareTo(v2) < 0;
        }
    }
}
