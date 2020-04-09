namespace Recursion_and_Backtracking.HackerRank
{
    public class Fibonacci_Numbers
    {
        public int Fibonacci(int n)
        {
            
            if (n == 1 || n == 2 ) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}