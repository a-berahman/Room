using System;
using LinkedLists.Model;

namespace LinkedLists.CrackingTheCodingInterview
{
    public class Sunm_Lists
    {
        public ListNode AddTwoNumbers(ListNode first, ListNode second)
        {
            var carry = 0;
            var dummy = new ListNode(0);
            var prev = dummy;
            while (first != null || second != null)
            {
                var x = first != null ? first.val : 0;
                var y = second != null ? second.val : 0;
                var sum = x + y + carry;
                prev.next = new ListNode(sum % 10);
                prev = prev.next;
                carry = sum / 10;
                if (first != null) first = first.next;
                if (second != null) second = second.next;
            }
            if (carry > 0)
                prev.next = new ListNode(carry);
            return dummy.next;
        }
    }
}