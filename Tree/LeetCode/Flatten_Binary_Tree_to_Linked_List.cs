using System.Collections.Generic;

namespace Tree.LeetCode
{
    public class Flatten_Binary_Tree_to_Linked_List
    {

        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;
            var node=root;
            while(node!=null)
            {
                while(node.left!=null)
                {
                    var rightmost=node.left;
                    while(rightmost.right!=null)
                    rightmost=rightmost.right;

                    rightmost.right=node.right;
                    node.right=node.left;
                    node.left=null;
                }
                node=node.right;
            }
        }

        // public void Flatten(TreeNode root)
        // {
        //     root = FlattenPrepare(root);
        // }
        // private TreeNode FlattenPrepare(TreeNode node)
        // {
        //     if (node == null)
        //         return null;
        //     if (node.left == null && node.right == null)
        //         return node;

        //     var leftTail = FlattenPrepare(node.left);
        //     var rightTail = FlattenPrepare(node.right);

        //     if (leftTail != null)
        //     {
        //         leftTail.right = node.right;
        //         node.right = node.left;
        //         node.left = null;
        //     }
        //     return rightTail != null ? rightTail : leftTail;
        // }
    }
}
