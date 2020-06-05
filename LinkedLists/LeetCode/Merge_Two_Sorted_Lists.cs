
namespace LinkedLists.LeetCode
{
    public class Merge_Two_Sorted_Lists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // define two variable for head and movment variable
            var head = new ListNode(-1);
            var prev = head;

            //traversing in variable till l1 and l2 !=null
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }
            prev.next = l1 != null ? l1 : l2;

            //if l1 or l2 length bigger than each other , involve
            return head.next;
        }

    }
}

