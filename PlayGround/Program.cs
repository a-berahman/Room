using System;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree.Utiliz().CreateTestTree();

            //https://bit.ly/2xhGs54
            //https://bit.ly/3a6oaRm with c++
            // Console.WriteLine(new Tree.Utiliz().height(tree));
            
            
            // new Tree.Utiliz().VisitNodeInOrder(tree);
            var g=new PlayGround.Graphs.Utiliz().CreateGraph();
            new PlayGround.Graphs.Utiliz().DepthFirstSearch(g);
            new PlayGround.Graphs.Utiliz().BreadthFirstSearch(g);

        }
    }
}
