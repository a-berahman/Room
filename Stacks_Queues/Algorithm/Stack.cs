using System;

namespace Stacks_Queues.Algorithm
{
    /// <summary>
    /// is a linear collection which has last in first out (lifo) semantics
    /// elements are being added to the top of the stack and get removed from top as well
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        protected Node<T> Head { get; set; }

        /// <summary>
        /// add a new element to the top of the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            var _node = new Node<T>() { Next = null, Value = value };
            if (Head == null)
            {
                Head = _node;
                return;
            }
            _node.Next = Head;
            Head = _node;
        }
        /// <summary>
        /// remove from top of the stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (Head == null) throw new InvalidOperationException("Head is Empty");
            var _currentNode = Head.Value;
            Head = Head.Next;
            return _currentNode;

        }

        /// <summary>
        /// return the element from the top of the stack.
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