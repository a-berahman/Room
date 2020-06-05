using System.Collections.Generic;

namespace LinkedLists.LeetCode
{
    public class LRUCache
    {
        private readonly int capacity;

        private int count;
        private readonly DoubleLinkedListNode head;
        private readonly Dictionary<int, DoubleLinkedListNode> myDictionary;
        public LRUCache(int capacity)
        {
            head = new DoubleLinkedListNode(-1, -1);
            head.Next = head;
            head.Previous = head;
            this.capacity = capacity;
            myDictionary = new Dictionary<int, DoubleLinkedListNode>();
        }

        public int Get(int key)
        {
            DoubleLinkedListNode node;
            myDictionary.TryGetValue(key, out node);
            if (node == null)
            {
                return -1;
            }

            this.MoveItToFirstElementAfterHead(node);

            return node.KeyValue.Value;
        }

        public void Put(int key, int value)
        {
            DoubleLinkedListNode node;
            myDictionary.TryGetValue(key, out node);
            if (node == null)
            {
                if (this.count == this.capacity)
                {
                    // remove the last element
                    myDictionary.Remove(head.Previous.KeyValue.Key);
                    head.Previous = head.Previous.Previous;
                    head.Previous.Next = head;

                    count--;
                }

                // create new node and add to dictionary
                var newNode = new DoubleLinkedListNode(key, value);
                myDictionary[key] = newNode;

                this.InsertAfterTheHead(newNode);

                // increase count
                count++;
            }
            else
            {
                node.KeyValue = new KeyValuePair<int, int>(key, value);
                this.MoveItToFirstElementAfterHead(node);
            }
        }

        private void MoveItToFirstElementAfterHead(DoubleLinkedListNode node)
        {
            RemoveCurrentNode(node);

            this.InsertAfterTheHead(node);
        }

        private void InsertAfterTheHead(DoubleLinkedListNode node)
        {
            // insert after the head
            node.Next = this.head.Next;
            node.Previous = this.head;
            this.head.Next.Previous = node;
            this.head.Next = node;
        }

        private static void RemoveCurrentNode(DoubleLinkedListNode node)
        {
            // remove current node
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
        }
    }
    public class DoubleLinkedListNode
    {
        public KeyValuePair<int, int> KeyValue { get; set; }

        public DoubleLinkedListNode Next { get; set; }

        public DoubleLinkedListNode Previous { get; set; }

        public DoubleLinkedListNode(int key, int value)
        {
            this.KeyValue = new KeyValuePair<int, int>(key, value);
            Next = null;
            Previous = null;
        }
    }
}