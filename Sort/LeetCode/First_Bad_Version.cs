using System;

namespace Sort.LeetCode
{
    public class First_Bad_Version
    {
        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else { left = mid + 1; }

            }
            return left;
        }
        //sample baraye inke error nade
        private bool IsBadVersion(int mid)
        {
            return true;
        }
    }
}
