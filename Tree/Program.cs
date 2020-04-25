using System;
using Tree.Model;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem statment is 'Tree: Height of a Binary Tree' -> https://bit.ly/2Vs0LEV
            //Solution in hackerrank platform with c++ -> 'https://bit.ly/34Bs43L'
            // var _tree = new Node(4,
            // new Node(2, new Node(1), new Node(3)),
            // new Node(7, left: new Node(6)));
            // new HackerRank.Height_of_a_Binary_Tree().height(_tree);

            //Problem statment is 'Binary Search Tree : Lowest Common Ancestor' -> https://bit.ly/2RGflay
            //Solution in hackerrank platform with c++ -> https://bit.ly/2VtMBTD
            // var _root = new Node(4, new Node(2, new Node(1), new Node(3)), new Node(7, left: new Node(6)));
            // var _currentNode = new HackerRank.Lowest_Common_Ancestor().LCA(_root, 1, 7);
            // Console.WriteLine(_currentNode.Value);



            //Problem statment is 'Trees: Is This a Binary Search Tree?' -> https://bit.ly/2XKkl1R
            //Solution in hackerrank platform with c++ -> https://bit.ly/2wNaEoc 
            var _bst = new Node(4, new Node(2, new Node(1), new Node(3)), new Node(6, new Node(5), new Node(7)));
            Console.WriteLine(new HackerRank.Is_This_a_Binary_Search_Tree().checkBST(_bst) ? "Yes" : "No");
        }
    }
}
