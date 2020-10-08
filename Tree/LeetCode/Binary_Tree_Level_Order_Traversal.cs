using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_Level_Order_Traversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            var Q = new Queue<(TreeNode node, int level)>();
            Q.Enqueue((root, 0));
            while (Q.Any())
            {
                var pair = Q.Dequeue();
                if (res.Count <= pair.level)
                {
                    res.Add(new List<int>());
                }
                res[pair.level].Add(pair.node.val);
                if (pair.node.left != null)
                {
                    Q.Enqueue((pair.node.left, pair.level + 1));
                }
                if (pair.node.right != null)
                {
                    Q.Enqueue((pair.node.right, pair.level + 1));
                }
            }
            return res;
        }
    }
}