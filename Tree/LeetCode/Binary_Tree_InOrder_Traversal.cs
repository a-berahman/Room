using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_InOrder_Traversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var stk = new Stack<TreeNode>();
            var res = new List<int>();

            while (root != null || stk.Any())
            {
                while (root != null)
                {
                    stk.Push(root);
                    root = root.left;
                }
                root = stk.Pop();
                res.Add(root.val);
                root = root.right;
            }

            return res;
        }
    }
}