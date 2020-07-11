using System.Linq;

namespace Implementation.HackerRank
{
    public class Angry_Professor
    {
        public string angryProfessor(int k, int[] a)
        {
            return a.Count(c => c <= 0) < k ? "YES" : "NO";
        }
    }
}