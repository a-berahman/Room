using System;
using System.Collections.Generic;
using System.IO;


namespace Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem statment is 'Linked Lists: ' -> https://bit.ly/2U90kzJ
            //Solution in hackerrank platform ->https://bit.ly/2xZu21C
            Console.WriteLine(new HackerRank.Balanced_Brackets().isBalanced("{(([)])}"));

            //Problem statment is 'Queues: A Tale of Two Stacks' -> https://bit.ly/2WATchh
            //Solution in hackerrank platform ->https://bit.ly/3ah4GdO
            var _inputs = new List<string>();
            _inputs.Add("1 42");
            _inputs.Add("2");
            _inputs.Add("1 14");
            _inputs.Add("3");
            _inputs.Add("1 28");
            _inputs.Add("3");
            _inputs.Add("1 60");
            _inputs.Add("1 78");
            _inputs.Add("2");
            _inputs.Add("2");
            new HackerRank.A_Tale_of_Two_Stacks().QueueProcessing(_inputs);



            //Problem statment is 'Largest Rectangle' -> https://bit.ly/39dFO5t
            //Solution in hackerrank platform -> https://bit.ly/3dmZ181
            //Resources : https://bit.ly/33BUKJq and https://bit.ly/3djosYd
            Console.WriteLine(new HackerRank.Largest_Rectangle().largestRectangle(new int[] { 1, 2, 3, 4, 5 }));



        }
    }
}
