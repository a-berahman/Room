using System;
namespace Stacks_Queues.Algorithm.PriorityQueues
{
    public class UnOrderedMaxPQ
    {
        private int[] PQ { get; set; }
        private int N = 0;
        public UnOrderedMaxPQ(int arrayCapacity)
        {
            PQ = new int[arrayCapacity];
        }
        public void Insert(int item) => PQ[N++] = item;
        public int DeleteMax()
        {
            //assume the first is max
            int _max = 0;
            //traversing in the array
            for (int i = 1; i < N; i++)
            //check current i is bigger than previous index
                if (Less(_max, i)) _max = i;
            //at the end switch max index with last index of array
            Exch(_max, N - 1);
            //return max array and loitering
            return PQ[--N];
        }

        private void Exch(int i, int j)
        {
            var _copy = PQ[i];
            PQ[i] = PQ[j];
            PQ[j] = _copy;
        }

        private bool Less(int p, int q) => p.CompareTo(q) < 0;
    }
}