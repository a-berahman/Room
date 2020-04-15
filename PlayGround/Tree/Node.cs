namespace PlayGround.Tree
{
    public class Node
    {
        public Node(int value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}