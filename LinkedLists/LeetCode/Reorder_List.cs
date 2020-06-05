using System;

namespace LinkedLists.LeetCode
{
    public class Reorder_List
    {
        public void ReorderList(ListNode head)
        {
            if (head == null) return;
            //first i find the middle of linkedlists
            var slow = head; var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            //slow is middle of linked list

            //second reverse second part
            var currentList = slow;
            ListNode previus = null;
            ListNode temp = null;
            while (currentList != null)
            {
                temp = currentList.next;
                currentList.next = previus;
                previus = currentList;
                currentList = temp;
            }
            //last merge 2 part
            var firstNode = head;
            var secondNode = previus;


            while (secondNode.next != null)
            {
                temp = firstNode.next;
                firstNode.next = secondNode;
                firstNode = temp;

                temp = secondNode.next;
                secondNode.next = firstNode;
                secondNode = temp;
            }


        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}