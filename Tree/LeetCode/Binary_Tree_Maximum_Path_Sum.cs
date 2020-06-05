using System;

namespace Tree.LeetCode
{
    public class Binary_Tree_Maximum_Path_Sum
    {
        int max = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            MaxGain(root);
            return max;
        }
        private int MaxGain(TreeNode node)
        {
            if (node == null) return 0;

            var left = Math.Max(MaxGain(node.left), 0);
            var right = Math.Max(MaxGain(node.right), 0);

            var newPath = node.val + left + right;
            max = Math.Max(newPath, max);

            return node.val + Math.Max(left, right);
            
        }
    }
}



// 