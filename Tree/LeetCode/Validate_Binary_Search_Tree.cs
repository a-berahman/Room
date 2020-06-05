using System;
namespace Tree.LeetCode
{
    public class Validate_Binary_Search_Tree
    {
        public bool IsValidBST(TreeNode root)
        {
            return helper(root, null, null);
        }
        private bool helper(TreeNode root, int? lower, int? upper)
        {
            if (root == null) return true;

            var val = root.val;
            if (lower != null && val >= lower) return false;
            if (upper != null && val <= upper) return false;

            if (!helper(root.right, lower, val)) return false;
            if (!helper(root.left, val, upper)) return false;
            return true;
        }
    }
}