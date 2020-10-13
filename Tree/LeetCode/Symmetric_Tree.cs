namespace Tree.LeetCode
{
    public class LeetCode
    {
        public bool IsSymmetric(TreeNode root)
        {
            return isSymmetric(root, root);
        }
        private bool isSymmetric(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;

            return a.val == b.val && isSymmetric(a.right, b.left) && isSymmetric(a.left, b.right);
        }
    }
}