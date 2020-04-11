using System;

namespace Recursion_and_Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://en.wikipedia.org/wiki/Fibonacci_number
            //Problem statment is 'Recursion: Fibonacci Numbers' -> https://bit.ly/3e12s4v
            //Solution in hackerrank platform -> https://bit.ly/2ReFDQX
            //Console.WriteLine(new HackerRank.Fibonacci_Numbers().Fibonacci(5));

            //Problem statment is 'Recursion: Davis' Staircase' -> https://bit.ly/3bY62KR
            // Console.WriteLine(new HackerRank.Davis_Staircase().stepPerms(7));

            var _crossWord = new string[10];
            _crossWord[0] = "+-++++++++";
            _crossWord[1] = "+-++++++++";
            _crossWord[2] = "+-++++++++";
            _crossWord[3] = "+-----++++";
            _crossWord[4] = "+-+++-++++";
            _crossWord[5] = "+-+++-++++";
            _crossWord[6] = "+++++-++++";
            _crossWord[7] = "++------++";
            _crossWord[8] = "+++++-++++";
            _crossWord[9] = "+++++-++++";

            new HackerRank.Crossword_Puzzle().crosswordPuzzle(_crossWord, "LONDON;DELHI;ICELAND;ANKARA");

        }
    }
}
