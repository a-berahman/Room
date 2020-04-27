using System;

namespace Stacks_Queues.Algorithm
{
    /// <summary>
    /// is a linear collection which has last in first out (lifo) semantics
    /// elements are being added to the top of the stack and get removed from top as well
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackWithLinkedList<T>
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

    public class StackWithArray<T>
    {
        //use array to store N items on stack
        private T[] Head { get; set; }
        private int N = 0;



        public StackWithArray()
        {
            Head = new T[1];
        }

        /// <summary>
        /// add a new object to the top of the stack
        /// </summary>
        public void Push(T item)
        {
            var _copyOfArray = Head;
            //set double size of array when array is full
            if (N == Head.Length) DoResize(Head.Length * 2);
            Head[N++] = item;
        }
        /// <summary>
        /// change array size
        /// </summary>
        private void DoResize(int arrayLenght)
        {
            var _copyOfArray = new T[arrayLenght];
            for (int i = 0; i < N; i++)
                _copyOfArray[i] = Head[i];
            Head = _copyOfArray;
        }

        /// <summary>
        /// remove a object on top of the stack
        /// </summary>
        public T Pop()
        {
            //it is loitering, what is loitering? Holding reference to an object when it is no longer needed
            //return Head[--N]; 

            //if you want to avoids loitering:
            //garbage collector can reclaim memory
            //only if no outstanding reference
            T item = Head[--N];
            Head[N] = default(T);
            //halve size of array when array is one-quarter full
            if (N > 0 && N == Head.Length / 4) DoResize(Head.Length / 2);

            return item;
        }

        public bool isEmpty()
        {
            return N == 0;
        }
    }
}