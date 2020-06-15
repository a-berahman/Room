using System;
using LinkedLists.Model;

namespace LinkedLists.CrackingTheCodingInterview
{
    public class Remove_Dups
    {
        public void DeleteDupsFirstApproach(ListNode head)
        {
            var current = head;
            while (current != null)
            {
                var runner = current;
                while (runner.next != null)
                {
                    if (runner.next.val == current.val)
                        runner.next = runner.next.next;
                    else runner = runner.next;
                }
                current = current.next;
            }
        }

        public void DeleteDupsSecondApproach(ListNode head)
        {
            if (head == null)
                return;
            var previous = head;
            var current = previous.next;

            while (current != null)
            {
                var runner = head;
                while (runner != current)
                {
                    if (runner.val == current.val)
                    {
                        var temp = current.next;
                        previous.next = temp;
                        current = temp;

                        break;
                    }
                    runner = runner.next;
                }

                if (runner == current)
                {
                    previous = current;
                    current = current.next;
                }
            }
        }
    }
}