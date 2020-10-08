using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_Postorder_Traversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            var stk1 = new Stack<TreeNode>();
            var stk2 = new Stack<TreeNode>();
            if (root == null)
            {
                return res;
            }
            stk1.Push(root);

            while (stk1.Any())
            {
                var temp = stk1.Pop();
                stk2.Push(temp);
                if (temp.left != null)
                {
                    stk1.Push(temp.left);
                }
                if (temp.right != null)
                {
                    stk1.Push(temp.right);
                }
            }
            while (stk2.Any())
            {
                var temp = stk2.Pop();
                res.Add(temp.val);
            }

            return res;

        }
    }
}