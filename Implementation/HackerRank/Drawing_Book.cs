using System;

namespace Implementation.HackerRank
{
    public class Drawing_Book
    {
        public int pageCount(int n, int p)
        {
            int front = p / 2;
            int end = (n / 2) - front;
            return Math.Min(end, front);
        }
    }
}