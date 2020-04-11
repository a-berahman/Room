namespace Recursion_and_Backtracking.HackerRank
{
    public class Davis_Staircase
    {
        //Memorizaiton way:
        public int stepPerms(int n)
        {
            //define _memo variable because i want to store
            //calculation, and if i need to repeat the calculation,
            //we take the result from the storage instead
            var _memo = new int[n + 1];
            _memo[0] = 1;
            _memo[1] = 1;
            return Fib(n);

            int Fib(int i)
            {
                if (i < 0) return 0;
                if (_memo[i] > 0)
                    return _memo[i];
                //maintain the value in _memo variable
                _memo[i] = Fib(i - 1) + Fib(i - 2) + Fib(i - 3);

                return _memo[i];
            }
        }

    }
}