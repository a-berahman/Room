using System;

namespace Arrays_String.HackerRank
{
    public class Circular_Array_Rotation
    {
        public int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            RightRotate(a,k,a.Length);
              for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = a[queries[i]];
            }
            return queries;

        }

        private void RightRotate(int[] a, int k, int n)
        {
            ReverseArray(a,0,n-1);
            ReverseArray(a,0,k-1);
            ReverseArray(a,k,n-1);
        }

        private void ReverseArray(int[] a, int start, int end)
        {
            while(start<end)
            {
                int temp=a[start];
                a[start]=a[end];
                a[end]=temp;
                end--;
                start++;
            }
        }
    }
}