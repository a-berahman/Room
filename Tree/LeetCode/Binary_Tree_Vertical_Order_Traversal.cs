using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree.LeetCode
{
    public class Binary_Tree_Vertical_Order_Traversal
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            List<IList<int>> output = new List<IList<int>>();
            if (root == null)
            {
                return output;
            }

            Dictionary<int, List<int>> columnTable = new Dictionary<int, List<int>>();
            // Pair of node and its column offset
            Queue<KeyValuePair<TreeNode, int>> queue = new Queue<KeyValuePair<TreeNode, int>>();
            int column = 0;
            queue.Enqueue(new KeyValuePair<TreeNode, int>(root, column));

            int minColumn = 0, maxColumn = 0;

            while (queue.Any())
            {
                KeyValuePair<TreeNode, int> p = queue.Dequeue();
                root = p.Key;
                column = p.Value;

                if (root != null)
                {
                    if (!columnTable.ContainsKey(column))
                    {
                        columnTable.Add(column, new List<int>());
                    }
                    columnTable[column].Add(root.val);
                    minColumn = Math.Min(minColumn, column);
                    maxColumn = Math.Max(maxColumn, column);

                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.left, column - 1));
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.right, column + 1));
                }
            }

            for (int i = minColumn; i < maxColumn + 1; ++i)
            {
                output.Add(columnTable[i]);
            }

            return output;
        }
    }
}