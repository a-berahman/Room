using System;
using LinkedLists.Model;

namespace LinkedLists.CrackingTheCodingInterview
{
    public class Partition
    {
        public ListNode partition(ListNode head, int x)
        {

            /* Let us initialize first and last nodes of  
            three linked lists  
                1) Linked list of values smaller than x.  
                2) Linked list of values equal to x.  
                3) Linked list of values greater than x.*/
            ListNode smallerHead = null, smallerLast = null;
            ListNode greaterLast = null, greaterHead = null;
            ListNode equalHead = null, equalLast = null;

            // Now iterate original list and connect nodes  
            // of appropriate linked lists.  
            while (head != null)
            {
                // If current node is equal to x, append it  
                // to the list of x values  
                if (head.val == x)
                {
                    if (equalHead == null)
                        equalHead = equalLast = head;
                    else
                    {
                        equalLast.next = head;
                        equalLast = equalLast.next;
                    }
                }

                // If current node is less than X, append  
                // it to the list of smaller values  
                else if (head.val < x)
                {
                    if (smallerHead == null)
                         smallerHead =smallerLast= head;
                    else
                    {
                        smallerLast.next = head;
                        smallerLast = smallerLast.next;
                    }
                }
                else // Append to the list of greater values  
                {
                    if (greaterHead == null)
                         greaterHead=greaterLast = head;
                    else
                    {
                        greaterLast.next = head;
                        greaterLast = greaterLast.next;
                    }
                }
                head = head.next;
            }

            // Fix end of greater linked list to NULL if this  
            // list has some nodes  
            if (greaterLast != null)
                greaterLast.next = null;

            // Connect three lists  

            // If smaller list is empty  
            if (smallerHead == null)
            {
                if (equalHead == null)
                    return greaterHead;
                equalLast.next = greaterHead;
                return equalHead;
            }

            // If smaller list is not empty  
            // and equal list is empty  
            if (equalHead == null)
            {
                smallerLast.next = greaterHead;
                return smallerHead;
            }

            // If both smaller and equal list  
            // are non-empty  
            smallerLast.next = equalHead;
            equalLast.next = greaterHead;
            return smallerHead;
        }

        /* Function to print linked list */
        public void printList(ListNode head)
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
        }
    }
}