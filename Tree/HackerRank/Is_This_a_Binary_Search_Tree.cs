using System;
using Tree.Model;

namespace Tree.HackerRank
{
    public class Is_This_a_Binary_Search_Tree
    {
        Node _previous = null;
        // What is BST ? 
        // according to https://en.wikipedia.org/wiki/Binary_search_tree
        // BST is Binary Search Tree and binary search tree is a rooted binary tree,
        // whose internal nodes each store a key (and optionally, an associated value)
        // and each have two distinguished sub-trees, commonly denoted left and right.
        // The tree additionally satisfies the binary search property, which states that 
        // the key in each node must be greater than or equal to any key stored in the 
        // left sub-tree, and less than or equal to any key stored in the right sub-tree.
        // The leaves (final nodes) of the tree contain no key and have no structure to
        // distinguish them from one another.
        // What is In-Order traversaling ?
        // When we visit left child  recursively, then the root node and then the right child nodes.
        public bool checkBST(Node root)
        {
            if (root == null) return true;


            //firstly, we traversaling in-order in the tree 
            //and maintain root value in a varibale which name is Previous
            if (!checkBST(root.Left))
                return false;
            //this condition is checking our values is sorted, if it is not ascending so it's not BST
            if (_previous != null && root.Value <= _previous.Value)
                return false;

            _previous = root;
            return checkBST(root.Right);
        }
    }
}