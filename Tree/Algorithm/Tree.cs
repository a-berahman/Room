using System;
using Tree.Model;

namespace Tree.Algorithm
{
    public class Tree
    {
        public Node Search(Node tree, int value)
        {
            if (tree == null) return null;
            if (tree.Value == value) return tree;
            if (value <= tree.Value) return Search(tree.Left, value);
            return Search(tree.Right, value);
        }

        public void VisitNodePreOrder(Node node, int level = 0)
        {
            if (node == null) return;

            var seperator = new string('-', level);
            Console.WriteLine($"{seperator}{node.Value}");

            VisitNodePreOrder(node.Left, level + 1);
            VisitNodePreOrder(node.Right, level + 1);

        }
        public void VisitNodePostOrder(Node node, int level = 0)
        {
            if (node == null) return;

            VisitNodePostOrder(node.Left, level + 1);
            VisitNodePostOrder(node.Right, level + 1);
            var seperate = new string('-', level);
            Console.WriteLine($"{seperate}{node.Value}");
        }

        public void VisitNodeInOrder(Node node, int level = 0)
        {
            if (node == null) return;

            VisitNodeInOrder(node.Left, level + 1);
            string seperator = new string('-', level);
            Console.WriteLine($"{seperator}{node.Value}");

            VisitNodeInOrder(node.Right, level + 1);
        }

        public Node Put(Node x, int value)
        {

            if (x == null) return new Node(value, left: null, right: null, count: 1, color: Node.Red);
            var _cmp = value.CompareTo(x.Value);
            if (_cmp < 0) x.Left = Put(x.Left, value);
            else if (_cmp > 0) x.Right = Put(x.Right, value);
            else x.Value = value;


            if (isRead(x.Right) && !isRead(x.Left)) x = RotateLeft(x);
            if (isRead(x.Left) && isRead(x.Left.Left)) x = RotateRight(x);
            if (isRead(x.Left) && isRead(x.Right)) x = FlipColor(x);

            x.Count = 1 + Size(x.Left) + Size(x.Right);
            return x;

        }

        public Node Delete(Node x, int value)
        {
            if (x == null) return null;
            var _cmp = value.CompareTo(x.Value);
            if (_cmp < 0) x.Left = Delete(x.Left, value);
            if (_cmp > 0) x.Right = Delete(x.Right, value);
            else
            {
                if (x.Right == null) return x.Left;
                if (x.Left == null) return x.Right;

                var _t = x;
                x = Min(_t.Right);
                x.Right = DeleteMin(_t.Right);
                x.Left = _t.Left;
            }
            x.Count = 1 + Size(x.Right) + Size(x.Left);
            return x;


        }

        private Node DeleteMin(Node x)
        {
            if (x.Left == null) return x.Right;
            x.Left = DeleteMin(x.Left);
            x.Count = 1 + Size(x.Right) + Size(x.Left);
            return x;
        }
        //how many keys<k?
        public int Rank(Node x, int value)
        {
            if (x == null) return 0;

            var _cmp = value.CompareTo(x.Value);
            if (_cmp < 0) return Rank(x.Left, value);
            else if (_cmp > 0) return 1 + (int)Size(x.Left) + Rank(x.Right, value);
            else return (int)Size(x.Left);
        }
        public Node Floor(Node x, int value)
        {
            if (x == null) return null;
            var _cmp = value.CompareTo(x.Value);
            if (_cmp == 0) return x;
            if (_cmp < 0) Floor(x.Left, value);

            var t = Floor(x.Right, value);
            if (t != null) return t;
            return x;


        }
        private Node Min(Node x)
        {
            if (x.Left != null) Min(x.Left);
            return x;
        }

        public Node Get(Node x, int value)
        {
            if (x != null)
            {
                var _cmp = value.CompareTo(x.Value);
                if (_cmp < 0) x = Get(x.Left, value);
                if (_cmp > 0) x = Get(x.Right, value);
                else return x;
            }
            return null;
        }

        private Node FlipColor(Node x)
        {
            x.Color = Node.Red;
            x.Left.Color = Node.Black;
            x.Right.Color = Node.Black;
            return x;
        }

        private Node RotateRight(Node x)
        {
            var _copy = x.Left;
            x.Left = _copy.Right;
            _copy.Right = x;
            _copy.Color = x.Color;
            x.Color = Node.Red;
            return _copy;
        }

        private Node RotateLeft(Node x)
        {
            var _copy = x.Right;
            x.Right = _copy.Left;
            _copy.Left = x;
            _copy.Color = x.Color;
            x.Color = Node.Red;
            return _copy;
        }

        private bool isRead(Node x) => (bool)x.Color;

        private int? Size(Node x)
        {
            if (x == null) return 0;
            return x.Count;
        }
    }
}