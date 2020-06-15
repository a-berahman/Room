using System;
using LinkedLists.Model;

namespace LinkedLists.CrackingTheCodingInterview
{
    public class Delete_Middle_Node
    {
        public ListNode DeleteMid(ListNode head)
        {
            var fast = head;
            var slow = head;
            ListNode prev = null;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                prev = slow;
                slow = slow.next;
            }
            prev.next = slow.next;
            
            return head;

        }
    }
}