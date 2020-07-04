using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation.HackerRank
{
    public class Bon_Appetit
    {
        public void bonAppetit(List<int> bill, int k, int b)
        {
            var notShare=bill[k]/2;
            
            bill.RemoveAt(k);
            var charged = bill.Sum() / 2;


            if (charged == b)
                Console.WriteLine("Bon Appetit");
            else Console.WriteLine(notShare);

        }
    }
}