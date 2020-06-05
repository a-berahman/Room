using System;

namespace Tree.LeetCode
{
    public class Diameter_Of_Binary_Tree
    {
        int ans;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            ans = 1;
            depth(root);
            return ans - 1;
        }
        public int depth(TreeNode node)
        {
            if (node == null) return 0;
            int L = depth(node.left);
            int R = depth(node.right);
            ans = Math.Max(ans, L + R + 1);
            return Math.Max(L, R) + 1;
        }

    }
}