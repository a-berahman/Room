using System;
using System.Linq;
using System.Text;

namespace Recursion_and_Backtracking.HackerRank
{
    public class Crossword_Puzzle
    {
        public char[][] PuzzleBoard;
        public string[] Words;




        public string[] crosswordPuzzle(string[] crossword, string word)
        {
            var _result = new string[10];
            Words = word.Split(';');
            PuzzleBoard = new char[10][];
            for (int i = 0; i < 10; i++)
                PuzzleBoard[i] = crossword[i].ToCharArray();

            BoardPrepare(0);

            for (int i = 0; i < PuzzleBoard.Length; i++)
            {
                var _str = new StringBuilder();
                foreach (var item in PuzzleBoard[i])
                {
                    _str.Append(item);
                }
                _result[i] = _str.ToString();
            }
            return _result;

        }

        public bool BoardPrepare(int wordindex)
        {
            if (wordindex == Words.Length) return true;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (PuzzleBoard[i][j] == '+') continue;
                    if (CheckVertical(i, j, wordindex) || CheckHorizontal(i, j, wordindex)) return true;
                }
            }
            return false;
        }

        public bool CheckVertical(int x, int y, int wordIndex)
        {
            if (10 - y < Words[wordIndex].Length) return false;
            for (int i = y; i < y + Words[wordIndex].Length; i++)
            {
                if (PuzzleBoard[x][i] != '-' && PuzzleBoard[x][i] != Words[wordIndex][i - y]) return false;
            }
            var tmp = new char[10];
            for (int i = y; i < y + Words[wordIndex].Length; i++)
            {
                tmp[i - y] = PuzzleBoard[x][i];
                PuzzleBoard[x][i] = Words[wordIndex][i - y];
            }

            if (BoardPrepare(wordIndex + 1)) return true;
            for (int i = y; i < y + Words[wordIndex].Length; i++)
            {
                PuzzleBoard[x][i] = tmp[i - y];
            }
            return false;
        }
        public bool CheckHorizontal(int x, int y, int wordIndex)
        {
            if (10 - x < Words[wordIndex].Length) return false;
            for (int i = x; i < x + Words[wordIndex].Length; i++)
            {
                if (PuzzleBoard[i][y] != '-' && PuzzleBoard[i][y] != Words[wordIndex][i - x]) return false;
            }
            var tmp = new char[10];
            for (int i = x; i < x + Words[wordIndex].Length; i++)
            {
                tmp[i - x] = PuzzleBoard[i][y];
                PuzzleBoard[i][y] = Words[wordIndex][i - x];
            }

            if (BoardPrepare(wordIndex + 1)) return true;
            for (int i = x; i < x + Words[wordIndex].Length; i++)
            {
                PuzzleBoard[i][y] = tmp[i - x];
            }
            return false;
        }
   
    }
}