namespace Tree.Model
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int value, Node left=null, Node right=null)
        {
            Right = right;
            Left = left;
            Value = value;
        }
    }
}