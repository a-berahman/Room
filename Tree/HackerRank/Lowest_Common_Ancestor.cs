using System;
using Tree.Model;

namespace Tree.HackerRank
{
    public class Lowest_Common_Ancestor
    {
        //we should traversing from top to bottom and while traversing
        //the first node encounter with value between v1 and v2 or 
        //same with one of them we should return the node
        //and we have 2 condtion, if node value bigger than v1 and v2
        //we should go to left side and if lesser than v1 and v2 we should
        //go to right side
        public Node LCA(Node root, int v1, int v2)
        {
            if (root == null) return null;

            //according to above explenation if root value is bigger than both of
            //inputs we should traversing recursively to the left
            if (root.Value > v1 && root.Value > v2)
                return LCA(root.Left, v1, v2);


            //according to above explenation if root value is lesser than both of
            //inputs we should traversing recursively to the right
            if (root.Value < v1 && root.Value < v2)
                return LCA(root.Right, v1, v2);
            //and finally if value not is bigger or smaller than both of value so 
            //it's located between them or it's a same with one of them
            return root;

        }
    }
}