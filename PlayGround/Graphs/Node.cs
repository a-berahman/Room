using System;
using System.Collections.Generic;

namespace PlayGround.Graphs
{
    public class Node
    {
        public int Id { get; set; }
        public List<Node> Children { get; set; }
        public Node(int value, params Node[] children)
        {
            Id = value;
            Children = new List<Node>(children);
        }
    }
}