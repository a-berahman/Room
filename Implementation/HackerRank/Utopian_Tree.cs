namespace Implementation.HackerRank
{
    public class Utopian_Tree
    {
        public int utopianTree(int n)
        {
            int height = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    height++;
                }
                else
                {
                    height *= 2;
                }
            }
            return height;
        }
    }
}
