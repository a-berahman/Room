using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return rSerialize(root, "");
        }

        private string rSerialize(TreeNode root, string str)
        {
            if (root == null)
            {
                str += "null,";
                return str;
            }

            str += root.val.ToString() + ",";
            str = rSerialize(root.left, str);
            str = rSerialize(root.right, str);

            return str;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            string[] strSplit = data.Split(',');

            return rDeserialize(strSplit.ToList());
        }
        private TreeNode rDeserialize(List<string> list)
        {
            if (!list.Any())
                return null;
            if (list[0] == "null")
            {
                list.RemoveAt(0);
                return null;
            }

            var root = new TreeNode(int.Parse(list[0]));
            list.RemoveAt(0);
            root.left = rDeserialize(list);
            root.right = rDeserialize(list);
            return root;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));

}