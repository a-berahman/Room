using System.Collections.Generic;
using System.Linq;

namespace Graph.LeetCode
{
    public class Is_Graph_Bipartite
    {
        public bool IsBipartite(int[][] graph)
        {
            int n = graph.Length;
            int[] color = Enumerable.Repeat(-1, n).ToArray();


            for (int start = 0; start < n; ++start)
            {
                if (color[start] == -1)
                {
                    Stack<int> stack = new Stack<int>();
                    stack.Push(start);
                    color[start] = 0;

                    while (stack.Any())
                    {
                        int node = stack.Pop();
                        foreach (int nei in graph[node])
                        {
                            if (color[nei] == -1)
                            {
                                stack.Push(nei);
                                color[nei] = color[node] ^ 1;
                            }
                            else if (color[nei] == color[node])
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}