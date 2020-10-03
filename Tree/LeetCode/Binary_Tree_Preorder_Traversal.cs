using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_Preorder_Traversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
            {
                return res;
            }
            if (root.left == null && root.right == null)
            {
                res.Add(root.val);
                return res;
            }

            Stack<TreeNode> stk = new Stack<TreeNode>();
            stk.Push(root);
            while (stk.Any())
            {
                var item = stk.Pop();
                res.Add(item.val);
                if (item.right != null)
                {
                    stk.Push(item.right);
                }
                if (item.left != null)
                {
                    stk.Push(item.left);
                }
            }
            return res;
        }
    }


}