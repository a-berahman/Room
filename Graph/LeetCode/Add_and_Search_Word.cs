using System.Collections.Generic;

namespace Graph.LeetCode
{
    public class WordDictionary
    {
        TrieNode root;
        bool canFind;

        /** Initialize your data structure here. */
        public WordDictionary()
        {
            root = new TrieNode();
            canFind = false;
        }

        public void AddWord(string word)
        {
            var n = word.Length;
            TrieNode curNode = root;
            for (int i = 0; i < n; i++)
            {
                var index = word[i] - 'a';
                if (curNode.nodes[index] == null)
                {
                    curNode.nodes[index] = new TrieNode();
                }
                curNode = curNode.nodes[index];

                if (i == n - 1)
                {
                    curNode.isWord = true;
                }
            }
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            canFind = false;
            DFS(root, word, 0);
            return canFind;
        }

        private void DFS(TrieNode root, string word, int i)
        {
            if (canFind) return;
            if (root == null) return;
            var n = word.Length;
            if (n == i)
            {
                if (root.isWord)
                {
                    canFind = true;
                }
                return;
            }
            if (word[i] == '.')
            {
                for (var j = 'a'; j <= 'z'; j++)
                {
                    DFS(root.nodes[j - 'a'], word, i + 1);
                }
            }
            else
            { 
                var index = word[i] - 'a';
                DFS(root.nodes[index], word, i + 1);
            }
        }
    }

    class TrieNode
    {
        public TrieNode[] nodes;
        public bool isWord;

        public TrieNode()
        {
            nodes = new TrieNode[26];
            isWord = false;
        }
    }

}

