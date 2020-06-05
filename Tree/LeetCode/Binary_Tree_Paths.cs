using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_Paths
    {
        public void construct_paths(TreeNode root, string path, List<string> paths)
        {
            if (root != null)
            {
                path += root.val.ToString();
                if ((root.left == null) && (root.right == null))  // if reach a leaf
                    paths.Add(path);  // update paths
                else
                {
                    path += "->";  // extend the current path
                    construct_paths(root.left, path, paths);
                    construct_paths(root.right, path, paths);
                }
            }
        }

        public List<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            construct_paths(root, "", paths);
            return paths.ToList();
        }

    }
}