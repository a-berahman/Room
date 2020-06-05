using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph.LeetCode
{
    public class Alien_Dictionary
    {
        public string AlienOrder(String[] words)
        {
            Dictionary<char, HashSet<char>> map = new Dictionary<char, HashSet<char>>();
            Dictionary<char, int> degree = new Dictionary<char, int>();
            String result = "";
            if (words == null || words.Length == 0) return result;
            foreach (string s in words)
            {
                foreach (char c in s.ToCharArray())
                {
                    degree[c] = 0;
                }
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                String cur = words[i];
                String next = words[i + 1];
                int length = Math.Min(cur.Length, next.Length);
                for (int j = 0; j < length; j++)
                {
                    char c1 = cur[j];
                    char c2 = next[j];
                    if (c1 != c2)
                    {
                        HashSet<char> set = new HashSet<char>();
                        if (map.ContainsKey(c1)) set = map[c1];
                        if (!set.Contains(c2))
                        {
                            set.Add(c2);
                            map[c1] = set;
                            degree[c2] = degree[c2] + 1;
                        }
                        break;
                    }
                }
            }
            Queue<char> q = new Queue<char>();
            foreach (char c in degree.Keys)
            {
                if (degree[c] == 0) q.Enqueue(c);
            }
            while (q.Any())
            {
                char c = q.Dequeue();
                result += c;
                if (map.ContainsKey(c))
                {
                    foreach (char c2 in map[c])
                    {
                        degree[c2] = degree[c2] - 1;
                        if (degree[c2] == 0) q.Enqueue(c2);
                    }
                }
            }
            if (result.Length != degree.Count()) return "";
            return result;
        }


    }
}

