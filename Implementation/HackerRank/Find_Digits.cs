using System;
namespace Implementation.HackerRank
{
    public class Find_Digits
    {
        public int findDigits(int n)
        {
            var currentNumber=n;
            int counter=0;
            while (n != 0)
            {
                if(n % 10!=0 && currentNumber%(n % 10)==0)
                counter++;
                n=n/10;
            }
            return counter;
        }
    }
}