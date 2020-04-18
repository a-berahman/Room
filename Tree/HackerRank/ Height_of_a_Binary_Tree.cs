using System;
using Tree.Model;

namespace Tree.HackerRank
{
    public class Height_of_a_Binary_Tree
    {
        //we should traversing recursively right and left side of tree
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
    }
}