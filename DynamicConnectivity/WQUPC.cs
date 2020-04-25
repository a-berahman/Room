using System;

namespace DynamicConnectivity
{
    public class WQUPC
    {
        public int[] Ids { get; set; }
        public int[] Siz { get; set; }
        /// <summary>
        ///initialize data structure with N objects
        ///</summery>
        public WQUPC(int n)
        {
            Ids = new int[n];
            //maintain count number of objects in the tree
            Siz = new int[n];
            for (int i = 0; i < n; i++)
            {
                Ids[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                Siz[i] = 1;
            }
        }
        /// <summary>
        ///chase parent pointers until reach root
        ///</summery>
        public int Root(int i)
        {
            while (i != Ids[i])
            {
                Ids[i] = Ids[Ids[i]];
                i = Ids[i];
            }

            return i;
        }
        /// <summary>
        ///are p and q in the same component?
        ///</summery>
        public bool isConnected(int p, int q)
        { return Root(p) == Root(q); }

        /// <summary>
        ///add connection between p and q
        ///</summery>
        public void Union(int p, int q)
        {
            int pid = Root(p);
            int qid = Root(q);

            if (Siz[pid] <= Siz[qid])
            {
                Ids[pid] = qid;
                Siz[qid] += Siz[pid];
            }
            else
            {
                Ids[qid] = pid;
                Siz[pid] += Siz[qid];
            }
        }
    }
}