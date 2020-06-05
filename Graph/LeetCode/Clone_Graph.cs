using System.Collections.Generic;

namespace Graph.LeetCode
{
    public class Clone_Graph
    {
        //DFS Approach
        Dictionary<Node, Node> marked = new Dictionary<Node, Node>();
        public Node CloneGraph(Node node)
        {
            if (node == null)
                return node;
            if (marked.ContainsKey(node))
                return marked[node];

            var clone = new Node(node.val);
            marked.Add(node, clone);
            foreach (var item in node.neighbors)
            {
                clone.neighbors.Add(CloneGraph(item));
            }
            return clone;
        }
    }
}
