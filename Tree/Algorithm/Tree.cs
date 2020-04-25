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

    }
}