using System;

namespace Stacks_Queues.Algorithm
{
    /// <summary>
    /// is a linear collection which has First in First Out (fifo) semantics
    /// queue is commonly implemented with a Linked List algorithm that keeps track of Two elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T>
    {

        protected Node<T> Tail { get; set; }
        protected Node<T> Head { get; set; }

        /// <summary>
        /// add a new element to the end of the queue
        /// </summary>
        /// <param name="value"></param>
        public void EnQueue(T value)
        {
            var _node = new Node<T> { Value = value, Next = null };
            if (Head == null)
            {
                Head = _node;
                Tail = Head;
                return;
            }

            Tail.Next = _node;
            Tail = _node;

        }
        /// <summary>
        /// remove the element from the front of the queue and return it.
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            if (Head == null) throw new InvalidOperationException("Head is empty");
            var _currentNode = Head.Value;
            Head = Head.Next;
            return _currentNode;
        }
        /// <summary>
        /// return the element from the front of the queue.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (Head == null) throw new InvalidOperationException("Head is empty");
            return Head.Value;
        }
        public override string ToString()
        {
            var _sb = new System.Text.StringBuilder();
            var _head = Head;
            _sb.Append("[");
            while (_head != null)
            {
                if (_head.Next != null)
                    _sb.Append(_head.Value + ", ");
                else
                    _sb.Append(_head.Value);
                _head = _head.Next;
            }
            _sb.Append("]");
            return _sb.ToString();
        }
        public bool IsNull()
        {
            return Head == null;
        }
    }

}