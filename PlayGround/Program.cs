using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            // int _inputCount = int.Parse(Console.ReadLine());
            // var _uf = new PlayGround.DynamicConnectivity.UF();
            // while (--_inputCount >= 0)
            // {
            //     int p = int.Parse(Console.ReadLine());
            //     int q = int.Parse(Console.ReadLine());

            //     if (!_uf.isConnected(p, q))
            //     {

            //     }
            //     else
            //     {
            //         Console.WriteLine("connected");
            //     }

            // }


            // Console.ReadLine();
        }
    }
}

namespace PlayGround.DynamicConnectivity.QuickFind
{
    public class UF
    {
        public int[] Ids { get; set; }
        public UF(int n)
        {
            Ids = new int[n];
            for (int i = 0; i < n; i++)
                Ids[i] = i;
        }

        public bool isConnected(int p, int q)
        {
            return Ids[p] == Ids[q];
        }

        public void Union(int p, int q)
        {
            for (int i = 0; i < Ids.Length; i++)
            {
                if (Ids[i] == Ids[p]) Ids[i] = Ids[q];
            }
        }

    }
}

namespace PlayGround.DynamicConnectivity.QuickUnion
{
    public class UF
    {
        public int[] Ids { get; set; }
        public UF(int n)
        {
            Ids = new int[n];
            for (int i = 0; i < n; i++)
                Ids[i] = i;
        }

        public int Root(int i)
        {
            while (Ids[i] != i) i = Ids[i];
            return i;
        }


        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            Ids[i] = j;
        }
    }
}

namespace PlayGround.DynamicConnectivity.WQUPC
{
    public class UF
    {
        public int[] Ids { get; set; }
        public int[] Siz { get; set; }
        public UF(int n)
        {
            Ids = new int[n];
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

        public int Root(int i)
        {
            while (i != Ids[i])
            {
                Ids[i] = Ids[Ids[i]];
                i = Ids[i];
            }

            return i;
        }
        public bool Connected(int p, int q)
        { return Root(p) == Root(q); }

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