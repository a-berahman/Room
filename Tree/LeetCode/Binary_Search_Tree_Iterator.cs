using System.Collections.Generic;

namespace Tree.LeetCode
{
    public class BSTIterator
    {
        readonly Stack<TreeNode> _mystack = new Stack<TreeNode>();
        public BSTIterator(TreeNode root)
        {
            findMostLeftNode(root, _mystack);
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return _mystack.Count > 0;
        }

        /** @return the next smallest number */
        public int Next()
        {
            var top = _mystack.Pop();
            findMostLeftNode(top.right, _mystack);

            return top.val;
        }

        private void findMostLeftNode(TreeNode root, Stack<TreeNode> mystack)
        {
            while (root != null)
            {
                mystack.Push(root);
                root = root.left;
            }
        }
    }
}