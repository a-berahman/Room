using System;
using LinkedLists.Model;

namespace LinkedLists.CrackingTheCodingInterview
{
    public class Return_Kth_to_Last
    {
        public int find(ListNode head, int k)
        {
            var dummy = new ListNode(0);
            dummy.next = head;
            var first = dummy;
            var second = dummy;

            for (int i = 1; i <= k + 1; i++)
                first = first.next;

            while (first != null)
            {
                first=first.next;
                second=second.next;
            }

            return second.next.val;

        }
    }
}