namespace Tree.Model
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public bool? Color { get; set; }
        public int? Count { get; set; }

        public static readonly bool Red = true;
        public static readonly bool Black = false;
        public Node(int value, Node left = null, Node right = null,int? count=null,bool? color=null)
        {
            Right = right;
            Left = left;
            Value = value;
            Color=color;
            Count=count;
        }
    }
}