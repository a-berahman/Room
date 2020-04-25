using System;

namespace DynamicConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            int _inputCount = int.Parse(Console.ReadLine());
            var _uf = new DynamicConnectivity.WQUPC(10);
            while (--_inputCount >= 0)
            {
                
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());

                if (!_uf.isConnected(p, q))
                {
                    _uf.Union(p, q);
                }
                else
                {
                    Console.WriteLine("connected");
                }

            }
            Console.ReadLine();
        }
    }
}
