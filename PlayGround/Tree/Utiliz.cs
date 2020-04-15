using System;

namespace PlayGround.Tree
{
    public class Utiliz
    {
        public Node CreateTestTree()
        {
            // return new Node(60, new Node(30,
            // new Node(10, new Node(1), new Node(20)),
            // new Node(40, new Node(35), new Node(50))),
            // new Node(100, new Node(80, new Node(70), new Node(90)),
            // new Node(120, left: new Node(110))));

            // return new Node(3,
            // new Node(2, left: new Node(1)),
            // new Node(5, new Node(4), new Node(6, right: new Node(7)))
            // );


            return new Node(4,
            new Node(2, new Node(1), new Node(3)),
            new Node(7, left: new Node(6)));
        }




        public int height(Node tree)
        {
            var _result = EdgesCounter(tree);
            return _result - 1;
        }
        private int EdgesCounter(Node tree)
        {
            if (tree == null) return 0;

            var _leftEdgeCount = EdgesCounter(tree.Left);
            var _rightEdgeCount = EdgesCounter(tree.Right);

            return _leftEdgeCount > _rightEdgeCount ? _leftEdgeCount + 1 : _rightEdgeCount + 1;
        }

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