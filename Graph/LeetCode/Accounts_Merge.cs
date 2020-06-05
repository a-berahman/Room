using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph.LeetCode
{
    public class Accounts_Merge
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var owner = new Dictionary<string, string>();

            var graph = new Dictionary<string, IList<IList<string>>>();

            foreach (var account in accounts)
            {
                var name = account.First();

                var emails = account.Skip(1).ToList();

                foreach (var email in emails)
                {
                    if (!graph.TryGetValue(email, out var lists))
                    {
                        lists = new List<IList<string>>();

                        graph.Add(email, lists);
                    }

                    lists.Add(emails);

                    owner[email] = name;
                }
            }

            var accountsMerge = new List<IList<string>>();

            var set = new HashSet<string>();

            foreach (var pair in owner)
            {
                if (set.Contains(pair.Key))
                {
                    continue;
                }

                var merge = AccountMerge(set, graph, pair.Key, pair.Value);

                accountsMerge.Add(merge);
            }

            return accountsMerge;
        }

        private static IList<string> AccountMerge(
            HashSet<string> set,
            IDictionary<string, IList<IList<string>>> graph,
            string email,
            string name)
        {
            var list = new List<string> { name };

            var emails = new List<string>();

            var queue = new Queue<string>();

            queue.Enqueue(email);

            set.Add(email);

            while (queue.Count != 0)
            {
                var front = queue.Dequeue();

                emails.Add(front);

                foreach (var others in graph[front])
                {
                    foreach (var other in others)
                    {
                        if (set.Contains(other))
                        {
                            continue;
                        }

                        set.Add(other);

                        queue.Enqueue(other);
                    }
                }
            }

            list.AddRange(emails.OrderBy(_ => _, StringComparer.Ordinal));

            return list;
        }

    }
}