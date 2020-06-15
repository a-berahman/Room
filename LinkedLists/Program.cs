using System;
using LinkedLists.Model;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(6, new ListNode(1, new ListNode(7)))))));
            Console.WriteLine(new CrackingTheCodingInterview.Partition().partition(node,3));
        }
    }
}
