using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_Right_Side_View
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            var preQueue = new Queue<TreeNode>();
            if (root != null)
                preQueue.Enqueue(root);
            var currQueue = new Queue<TreeNode>();
            while (preQueue.Any())
            {
                result.Add(preQueue.Peek().val);
                while (preQueue.Any())
                {
                    var node = preQueue.Dequeue();
                    if (node.right != null) currQueue.Enqueue(node.right);
                    if (node.left != null) currQueue.Enqueue(node.left);
                }

                while (currQueue.Any())
                {
                    preQueue.Enqueue(currQueue.Dequeue());
                }
            }


            return result;
        }

    }
}